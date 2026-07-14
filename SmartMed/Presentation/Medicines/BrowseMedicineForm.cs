using SmartMed.Business;
using SmartMed.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SmartMed.Presentation.Medicines
{
   
    public partial class BrowseMedicineForm : Form
    {
        private MedicineService medicineService = new MedicineService();
        private List<Medicine> medicines;
        private FlowLayoutPanel cardContainer;

        public BrowseMedicineForm()
        {
            InitializeComponent();

           
            medicine_card.Visible = false;

           
            cardContainer = new FlowLayoutPanel
            {
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = true,
                AutoScroll = true,
                Location = new Point(medicine_card.Location.X, medicine_card.Location.Y),
                Size = new Size(
                    this.ClientSize.Width - medicine_card.Location.X - 30,
                    this.ClientSize.Height - medicine_card.Location.Y - 30
                ),
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom,
                Padding = new Padding(10)
            };
         
            this.Controls.Add(cardContainer);

           
            btn_search.Click += btn_search_Click;

            LoadMedicines();
        }

        

        private void LoadMedicines()
        {
            LoadMedicines(null);
        }

        private void LoadMedicines(string searchTerm)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(searchTerm))
                {
                    medicines = medicineService.GetAllMedicines();
                }
                else
                {
                    medicines = medicineService.SearchMedicines(searchTerm);
                }

                cardContainer.Controls.Clear();

                if (medicines == null || medicines.Count == 0)
                {
                    Label noDataLabel = new Label
                    {
                        Text = string.IsNullOrWhiteSpace(searchTerm)
                            ? "No medicines available."
                            : "No medicines found matching your search.",
                        Font = new Font("Segoe UI", 16F, FontStyle.Bold),
                        ForeColor = Color.Gray,
                        AutoSize = true
                    };
                    cardContainer.Controls.Add(noDataLabel);
                    return;
                }

                foreach (var medicine in medicines)
                {
                    Panel card = CreateMedicineCard(medicine);
                    cardContainer.Controls.Add(card);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading medicines: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        private Panel CreateMedicineCard(Medicine medicine)
        {
            Panel card = new Panel
            {
                Size = medicine_card.Size,
                BorderStyle = medicine_card.BorderStyle,
                BackColor = medicine_card.BackColor,
                Margin = new Padding(50, 50, 50, 50),
                Tag = medicine.MedicineID
            };

          
            PictureBox imgBox = new PictureBox
            {
                Size = img_box.Size,
                Location = img_box.Location,
                SizeMode = img_box.SizeMode,
                BackColor = img_box.BackColor,
                TabStop = false
            };

            try
            {
                if (!string.IsNullOrEmpty(medicine.ImageURL))
                {
                    imgBox.ImageLocation = medicine.ImageURL;
                    imgBox.LoadAsync();
                }
                else
                {
                    imgBox.BackColor = Color.LightGray;
                }
            }
            catch
            {
                imgBox.BackColor = Color.LightGray;
            }
            card.Controls.Add(imgBox);

          
            Label lblName = new Label
            {
                Text = medicine.Name,
                Font = txt_MedicineName.Font,
                ForeColor = txt_MedicineName.ForeColor,
                AutoSize = txt_MedicineName.AutoSize,
                Location = txt_MedicineName.Location,
                Size = txt_MedicineName.Size,
                TextAlign = txt_MedicineName.TextAlign
            };
            card.Controls.Add(lblName);

           
            string priceText = $"LKR {medicine.Price:F2}";
            Label lblPrice = new Label
            {
                Text = priceText,
                Font = txt_medicinePrice.Font,
                ForeColor = txt_medicinePrice.ForeColor,
                AutoSize = txt_medicinePrice.AutoSize,
                Location = txt_medicinePrice.Location,
                Size = txt_medicinePrice.Size,
                TextAlign = txt_medicinePrice.TextAlign
            };
            card.Controls.Add(lblPrice);

            CuoreUI.Controls.cuiButton btnCart = new CuoreUI.Controls.cuiButton
            {
                Content = "Add to Cart",
                Size = btn_cart.Size,
                Location = btn_cart.Location,
                Font = btn_cart.Font,
                NormalBackground = btn_cart.NormalBackground,
                NormalForeColor = btn_cart.NormalForeColor,
                NormalOutline = btn_cart.NormalOutline,
                HoverBackground = btn_cart.HoverBackground,
                HoverForeColor = btn_cart.HoverForeColor,
                HoverOutline = btn_cart.HoverOutline,
                PressedBackground = btn_cart.PressedBackground,
                PressedForeColor = btn_cart.PressedForeColor,
                PressedOutline = btn_cart.PressedOutline,
                CheckedBackground = btn_cart.CheckedBackground,
                CheckedForeColor = btn_cart.CheckedForeColor,
                CheckedOutline = btn_cart.CheckedOutline,
                Rounding = btn_cart.Rounding,
                OutlineThickness = btn_cart.OutlineThickness,
                TextAlignment = btn_cart.TextAlignment,
                TextPadding = btn_cart.TextPadding,
                TextSpacing = btn_cart.TextSpacing,
                Image = btn_cart.Image,
                ImageExpand = btn_cart.ImageExpand,
                CheckButton = btn_cart.CheckButton,
                Checked = false,
                DialogResult = DialogResult.None,
                Tag = medicine.MedicineID
            };
            btnCart.Click += (s, e) => AddToCart(medicine.MedicineID);
            card.Controls.Add(btnCart);

            card.Click += (s, e) => ViewMedicineDetails(medicine.MedicineID);

            return card;
        }

        

        private void btn_search_Click(object sender, EventArgs e)
        {
            string searchTerm = cuiTextBox1.Content.Trim();
            LoadMedicines(searchTerm);
        }

   

        private void AddToCart(int medicineId)
        {
            try
            {
                Medicine medicine = medicineService.GetMedicineById(medicineId);
                if (medicine == null)
                {
                    MessageBox.Show("Medicine not found.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (medicine.Stock <= 0)
                {
                    MessageBox.Show("Sorry, this medicine is out of stock.", "Out of Stock",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                CartManager.AddItem(
                    medicine.MedicineID,
                    medicine.Name,
                    medicine.Dosage,
                    medicine.Price,                          
                    medicine.Discount,                       
                    medicine.ImageURL,
                    medicine.RequiresPrescription,
                    1
                );

                MessageBox.Show($"Added '{medicine.Name}' to cart!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding to cart: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ViewMedicineDetails(int medicineId)
        {
            try
            {
                Medicine medicine = medicineService.GetMedicineById(medicineId);
                if (medicine == null) return;

                string details = $@"
                    Name: {medicine.Name}
                    Category: {medicine.Category?.CategoryName ?? "N/A"}
                    Supplier: {medicine.Supplier?.SupplierName ?? "N/A"}
                    Dosage: {medicine.Dosage ?? "N/A"}
                    Price: LKR {medicine.Price:F2}
                    Stock: {medicine.Stock}
                    Expiry: {medicine.ExpiryDate:yyyy-MM-dd}
                    Prescription: {(medicine.RequiresPrescription ? "Required" : "Not Required")}
                    Discount: {(medicine.Discount.HasValue ? medicine.Discount.Value.ToString() + "%" : "None")}
                ";

                MessageBox.Show(details, $"Medicine Details - {medicine.Name}",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void RefreshMedicines()
        {
            LoadMedicines(cuiTextBox1.Content.Trim());
        }
    }
}