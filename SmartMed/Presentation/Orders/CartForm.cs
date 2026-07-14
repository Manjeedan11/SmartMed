using SmartMed.Business;
using SmartMed.Data;
using SmartMed.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SmartMed.Presentation.Orders
{
    public partial class CartForm : Form
    {
        private Customer currentCustomer;
        private List<CartItem> cartItems;
        private Dictionary<int, Panel> itemPanels = new Dictionary<int, Panel>();
        private MedicineService medicineService = new MedicineService();
        private OrderService orderService = new OrderService();
        private PrescriptionRepository prescriptionRepo = new PrescriptionRepository();

        public CartForm(Customer customer)
        {
            InitializeComponent();
            currentCustomer = customer;
            LoadCart();
        }

        private void LoadCart()
        {
            cartItems = CartManager.Items.ToList();
            if (cartItems.Count == 0)
            {
                MessageBox.Show("Your cart is empty.", "Cart",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                return;
            }

           
            foreach (Control ctrl in cart_container.Controls)
            {
                if (ctrl != cart_ScrollBar)
                    cart_container.Controls.Remove(ctrl);
            }

          
            int y = 20;
            foreach (var item in cartItems)
            {
                Panel card = CreateCartCard(item);
                card.Location = new Point(20, y);
                cart_container.Controls.Add(card);
                y += card.Height + 10;
            }

            UpdateSummary();
        }

        private Panel CreateCartCard(CartItem item)
        {
            Panel card = new Panel
            {
                BorderStyle = BorderStyle.FixedSingle,
                Size = new Size(830, 180),
                Tag = item.MedicineID
            };

            
            PictureBox img = new PictureBox
            {
                Location = new Point(15, 15),
                Size = new Size(170, 140),
                SizeMode = PictureBoxSizeMode.Zoom,
                BackColor = Color.WhiteSmoke
            };
            if (!string.IsNullOrEmpty(item.ImageURL))
            {
                try { img.ImageLocation = item.ImageURL; img.LoadAsync(); } catch { }
            }
            card.Controls.Add(img);

            
            Label lblName = new Label
            {
                Text = item.Name,
                Font = new Font("Segoe UI", 18F, FontStyle.Bold),
                Location = new Point(200, 15),
                AutoSize = true
            };
            card.Controls.Add(lblName);

          
            if (!string.IsNullOrEmpty(item.Dosage))
            {
                Label lblDosage = new Label
                {
                    Text = item.Dosage,
                    Font = new Font("Segoe UI", 10F),
                    ForeColor = Color.Gray,
                    Location = new Point(200, 65),
                    AutoSize = true
                };
                card.Controls.Add(lblDosage);
            }

            
            Label lblPrice = new Label
            {
                Text = $"LKR {item.UnitPrice:F2}",
                Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold),
                Location = new Point(200, 130),
                AutoSize = true
            };
            card.Controls.Add(lblPrice);

          
            Panel qtyCard = new Panel
            {
                BorderStyle = BorderStyle.FixedSingle,
                Location = new Point(700, 130),
                Size = new Size(111, 35)
            };

            Button btnDecrease = new Button
            {
                Text = "-",
                Location = new Point(3, 3),
                Size = new Size(27, 26),
                Tag = item.MedicineID
            };
            btnDecrease.Click += (s, e) => ChangeQuantity(item.MedicineID, -1);
            qtyCard.Controls.Add(btnDecrease);

            Label lblQty = new Label
            {
                Text = item.Quantity.ToString(),
                Location = new Point(46, 5),
                AutoSize = true
            };
            qtyCard.Controls.Add(lblQty);

            Button btnIncrease = new Button
            {
                Text = "+",
                Location = new Point(79, 4),
                Size = new Size(27, 26),
                Tag = item.MedicineID
            };
            btnIncrease.Click += (s, e) => ChangeQuantity(item.MedicineID, 1);
            qtyCard.Controls.Add(btnIncrease);

            card.Controls.Add(qtyCard);

            
            if (item.RequiresPrescription)
            {
                var dropper = new CuoreUI.Controls.cuiFileDropper
                {
                    Location = new Point(630, 50),
                    Size = new Size(181, 75),
                    AllowDrop = true,
                    DashedOutline = true,
                    DashedOutlineColor = Color.FromArgb(128, 128, 128, 128),
                    DashLength = 8,
                    Filter = "Image files (*.jpg;*.jpeg;*.png;*.pdf)|*.jpg;*.jpeg;*.png;*.pdf",
                    NormalContent = "Drop prescription here",
                    UploadContent = "Click to upload",
                    UploadWithClick = true,
                    Tag = item.MedicineID
                };

                dropper.FileDropped += (s, e) =>
                {
              
                    var ctrl = s as CuoreUI.Controls.cuiFileDropper;
                    string filePath = null;
                    if (ctrl != null)
                    {
                     
                        var props = ctrl.GetType().GetProperties();
                        foreach (var prop in props)
                        {
                            if (prop.PropertyType == typeof(string) && (prop.Name.Contains("File") || prop.Name.Contains("Path") || prop.Name.Contains("Selected")))
                            {
                                filePath = prop.GetValue(ctrl, null) as string;
                                if (!string.IsNullOrEmpty(filePath))
                                    break;
                            }
                            else if (prop.PropertyType == typeof(string[]))
                            {
                                var files = prop.GetValue(ctrl, null) as string[];
                                if (files != null && files.Length > 0)
                                {
                                    filePath = files[0];
                                    break;
                                }
                            }
                        }
                    }

                    if (!string.IsNullOrEmpty(filePath))
                        OnPrescriptionDropped(item.MedicineID, filePath);
                    else
                        MessageBox.Show("Could not retrieve the prescription file. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                };

                card.Controls.Add(dropper);
            }

            
            Button btnDelete = new Button
            {
                Text = "Delete",
                Location = new Point(750, 15),
                Size = new Size(66, 31),
                Tag = item.MedicineID
            };
            btnDelete.Click += (s, e) => DeleteItem(item.MedicineID);
            card.Controls.Add(btnDelete);

      
            itemPanels[item.MedicineID] = card;

            return card;
        }

        private void ChangeQuantity(int medicineId, int delta)
        {
            var item = cartItems.FirstOrDefault(i => i.MedicineID == medicineId);
            if (item == null) return;

            int newQty = item.Quantity + delta;
            if (newQty < 1) return;

            CartManager.UpdateQuantity(medicineId, newQty);
           
            LoadCart();
        }

        private void DeleteItem(int medicineId)
        {
            CartManager.RemoveItem(medicineId);
            LoadCart();
        }

        private void OnPrescriptionDropped(int medicineId, string filePath)
        {
            var item = cartItems.FirstOrDefault(i => i.MedicineID == medicineId);
            if (item != null)
            {
                item.PrescriptionFilePath = filePath;
                MessageBox.Show($"Prescription uploaded for {item.Name}.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UpdateSummary()
        {
            decimal subTotal = CartManager.GetSubTotal();
            decimal totalDiscount = CartManager.GetTotalDiscount();
            decimal total = CartManager.GetTotal();

            fg_subTotal.Text = subTotal.ToString("N2");
            fg_discount.Text = totalDiscount.ToString("N2");
            fg_total.Text = total.ToString("N2");
        }

        private void btn_placeOrder_Click(object sender, EventArgs e)
        {
            
            var cartItems = CartManager.Items.ToList();

            if (cartItems.Count == 0)
            {
                MessageBox.Show("Your cart is empty.", "Place Order",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            var medicineService = new MedicineService();
            foreach (var item in cartItems)
            {
                var medicine = medicineService.GetMedicineById(item.MedicineID);
                if (medicine == null || medicine.Stock < item.Quantity)
                {
                    MessageBox.Show($"Not enough stock for '{item.Name}'. Available: {medicine?.Stock ?? 0}", "Stock Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            
            var missingPrescription = cartItems.Where(i => i.RequiresPrescription && string.IsNullOrEmpty(i.PrescriptionFilePath)).ToList();
            if (missingPrescription.Any())
            {
                string names = string.Join(", ", missingPrescription.Select(i => i.Name));
                MessageBox.Show($"The following medicines require a prescription:\n{names}\nPlease upload prescription files.", "Prescription Required",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                
                decimal total = CartManager.GetTotal();
                decimal? discount = CartManager.GetTotalDiscount() > 0 ? CartManager.GetTotalDiscount() : null;
                Order order = new Order(currentCustomer.customerId, total, discount);

                
                List<OrderItem> orderItems = new List<OrderItem>();
                foreach (var item in cartItems)
                {
                    
                    OrderItem orderItem = new OrderItem(0, item.MedicineID, item.Quantity, item.UnitPrice);
                    orderItems.Add(orderItem);
                }

                int orderId = orderService.CreateOrder(order, orderItems);

                var prescriptionService = new PrescriptionService();
                bool presSaved = prescriptionService.SavePrescriptions(orderId, currentCustomer.customerId, cartItems);

                if (!presSaved)
                {
                    MessageBox.Show("Some prescriptions could not be saved, but the order was placed. Please contact support.", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

           
                CartManager.Clear();
                MessageBox.Show($"Order #{orderId} placed successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error placing order: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}