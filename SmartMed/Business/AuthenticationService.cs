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

        public bool Register(User user, Customer customer)
        {
           
            user.Validate();
            customer.Validate();

            if (userRepo.EmailExists(user.email))
                throw new Exception("Email already registered.");

            
            int userId = userRepo.CreateUser(user);
       
            customer.SetUserId(userId);

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