using SmartMed.Data;
using SmartMed.Models;
using SmartMed.Utilities;
using System;

namespace SmartMed.Business
{
    public class AuthenticationService
    {
        private UserRepository userRepo = new UserRepository();
        private CustomerRepository customerRepo = new CustomerRepository();

        public User Login(string email, string password)
        {
         
            if (string.IsNullOrWhiteSpace(email))
                throw new Exception("Email is required.");
            if (string.IsNullOrWhiteSpace(password))
                throw new Exception("Password is required.");

  
            User user = userRepo.GetUserByEmail(email);
            if (user == null)
                throw new Exception("Invalid email or password.");

          
            bool isValid = PasswordHelper.VerifyPassword(password, user.passwordHash);
            if (!isValid)
                throw new Exception("Invalid email or password.");

           
            return user;
        }

        public bool Register(string email, string password, string fullName, string phone, string address)
        {
          
            if (string.IsNullOrWhiteSpace(email))
                throw new Exception("Email is required.");
            if (string.IsNullOrWhiteSpace(password))
                throw new Exception("Password is required.");
            if (password.Length < 6)
                throw new Exception("Password must be at least 6 characters.");
            if (string.IsNullOrWhiteSpace(fullName))
                throw new Exception("Full name is required.");
            if (string.IsNullOrWhiteSpace(phone))
                throw new Exception("Phone number is required.");
            if (string.IsNullOrWhiteSpace(address))
                throw new Exception("Address is required.");

     
            if (userRepo.EmailExists(email))
                throw new Exception("Email already registered.");

           
            string hashedPassword = PasswordHelper.HashPassword(password);

           
            User newUser = new User
            {
                email = email,
                passwordHash = hashedPassword,
                role = "Customer",       
                createdAt = DateTime.Now
            };

           
            int userId = userRepo.CreateUser(newUser);

         
            Customer customer = new Customer
            {
                userId = userId,        
                fullName = fullName,
                phoneNumber = phone,
                address = address
            };

            
            bool result = customerRepo.CreateCustomer(customer);

          
            return result;
        }

        
        public Customer LoginAsCustomer(string email, string password)
        {
          
            User user = Login(email, password);

         
            if (user.role != "Customer")
                throw new Exception("This user is not a customer.");

  
            return customerRepo.GetCustomerByUserId(user.userId);
        }
    }
}