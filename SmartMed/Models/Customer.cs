using System;

namespace SmartMed.Models
{
    public class Customer
    {
        public int customerId { get; private set; }
        public int userId { get; private set; }
        public string fullName { get; private set; }
        public string phoneNumber { get; private set; }
        public string address { get; private set; }

        public User User { get; set; }

        public Customer() { }

        public Customer(string fullName, string phoneNumber, string address)
        {
            if (string.IsNullOrWhiteSpace(fullName))
                throw new ArgumentException("Full name is required.", nameof(fullName));
            if (string.IsNullOrWhiteSpace(phoneNumber))
                throw new ArgumentException("Phone number is required.", nameof(phoneNumber));
            if (string.IsNullOrWhiteSpace(address))
                throw new ArgumentException("Address is required.", nameof(address));

            this.fullName = fullName;
            this.phoneNumber = phoneNumber;
            this.address = address;
        }

        public Customer(int customerId, int userId, string fullName, string phoneNumber, string address)
        {
            this.customerId = customerId;
            this.userId = userId;
            this.fullName = fullName;
            this.phoneNumber = phoneNumber;
            this.address = address;
        }

       
        public void UpdateProfile(string fullName, string phoneNumber, string address)
        {
            if (string.IsNullOrWhiteSpace(fullName))
                throw new ArgumentException("Full name is required.", nameof(fullName));
            if (string.IsNullOrWhiteSpace(phoneNumber))
                throw new ArgumentException("Phone number is required.", nameof(phoneNumber));
            if (string.IsNullOrWhiteSpace(address))
                throw new ArgumentException("Address is required.", nameof(address));

            this.fullName = fullName;
            this.phoneNumber = phoneNumber;
            this.address = address;
        }

        public void SetUserId(int userId)
        {
            if (this.userId != 0)
                throw new InvalidOperationException("User ID already set.");
            this.userId = userId;
        }

        public void SetCustomerId(int id)
        {
            if (this.customerId != 0)
                throw new InvalidOperationException("Customer ID already set.");
            this.customerId = id;
        }

        public void Validate()
        {
            if (string.IsNullOrWhiteSpace(fullName))
                throw new InvalidOperationException("Full name is required.");
            if (string.IsNullOrWhiteSpace(phoneNumber))
                throw new InvalidOperationException("Phone number is required.");
            if (string.IsNullOrWhiteSpace(address))
                throw new InvalidOperationException("Address is required.");
        }
    }
}