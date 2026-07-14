using SmartMed.Data;
using SmartMed.Models;
using System;
using System.Collections.Generic;

namespace SmartMed.Business
{
    public class MedicineService
    {
        private MedicineRepository repo = new MedicineRepository();

        public List<Medicine> GetAllMedicines()
        {
            return repo.GetAllMedicines();
        }

        public Medicine GetMedicineById(int id)
        {
            return repo.GetMedicineById(id);
        }

        public int CreateMedicine(Medicine medicine)
        {
            
            medicine.Validate();
            return repo.CreateMedicine(medicine);
        }

        public bool UpdateMedicine(Medicine medicine)
        {
            if (medicine.MedicineID <= 0)
                throw new Exception("Invalid medicine ID.");

            medicine.Validate();

            return repo.UpdateMedicine(medicine);
        }

        public bool DeleteMedicine(int id)
        {
            if (id <= 0)
                throw new Exception("Invalid medicine ID.");

            return repo.DeleteMedicine(id);
        }

        public List<Category> GetAllCategories()
        {
            return repo.GetAllCategories();
        }

        public List<Supplier> GetAllSuppliers()
        {
            return repo.GetAllSuppliers();
        }

        public List<Medicine> SearchMedicines(string searchTerm)
        {
            
            if (string.IsNullOrWhiteSpace(searchTerm))
                return repo.GetAllMedicines();

            var all = repo.GetAllMedicines();
            var results = new List<Medicine>();
            string term = searchTerm.ToLower();

            foreach (var med in all)
            {
                if (med.Name.ToLower().Contains(term) ||
                    (med.Category?.CategoryName?.ToLower().Contains(term) == true) ||
                    (med.Supplier?.SupplierName?.ToLower().Contains(term) == true))
                {
                    results.Add(med);
                }
            }
            return results;
        }

        public int GetMedicineCount()
        {
            return repo.GetMedicineCount();
        }
    }
}