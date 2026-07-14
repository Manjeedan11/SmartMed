using SmartMed.Models;
using SmartMed.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartMed.Business
{
    public class CustomerService
    {

        private CustomerRepository customerRepo = new CustomerRepository();
        public List<Customer> GetAllCustomers()
        {
            return customerRepo.GetAllCustomers();
        }

        public Customer GetCustomerById(int customerId)
        {
            return customerRepo.GetCustomerById(customerId);
        }


        public bool UpdateCustomer(Customer customer, string newEmail)
        {
           
            if (string.IsNullOrWhiteSpace(customer.fullName))
                throw new Exception("Full name is required.");
            if (string.IsNullOrWhiteSpace(customer.phoneNumber))
                throw new Exception("Phone number is required.");
            if (string.IsNullOrWhiteSpace(newEmail))
                throw new Exception("Email is required.");
            

            return customerRepo.UpdateCustomer(customer, newEmail);
        }

        public Customer GetCustomerByUserId(int userId)
        {
            return customerRepo.GetCustomerByUserId(userId);
        }

        public int GetCustomerCount()
        {
            return customerRepo.GetCustomerCount();
        }
    }
}
