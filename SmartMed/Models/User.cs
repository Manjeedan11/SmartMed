using SmartMed.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartMed.Models
{
    public class User
    {
        public int userId { get; private set; }
        public string email { get; private set; }
        public string passwordHash { get; private set; }
        public string role { get; private set; }
        public DateTime createdAt { get; private set; }

    
        public User() { }

        public User(string email, string passwordHash, string role)
        {
            if (string.IsNullOrWhiteSpace(email))
                throw new ArgumentException("Email is required.", nameof(email));
            if (string.IsNullOrWhiteSpace(passwordHash))
                throw new ArgumentException("Password hash is required.", nameof(passwordHash));
            if (string.IsNullOrWhiteSpace(role))
                throw new ArgumentException("Role is required.", nameof(role));

            this.email = email;
            this.passwordHash = passwordHash;
            this.role = role;
            this.createdAt = DateTime.Now;
        }


        public User(int userId, string email, string passwordHash, string role, DateTime createdAt)
            : this(email, passwordHash, role)
        {
            if (userId <= 0)
                throw new ArgumentException("Invalid user ID.", nameof(userId));
            this.userId = userId;
            this.createdAt = createdAt;
        }

        public void SetId(int id)
        {
            if (userId != 0)
                throw new InvalidOperationException("User ID already set.");
            if (id <= 0)
                throw new ArgumentException("Invalid user ID.", nameof(id));
            userId = id;
        }

        public void Validate()
        {
            if (string.IsNullOrWhiteSpace(email))
                throw new InvalidOperationException("Email is required.");
            if (string.IsNullOrWhiteSpace(passwordHash))
                throw new InvalidOperationException("Password hash is missing.");
            if (string.IsNullOrWhiteSpace(role))
                throw new InvalidOperationException("Role is required.");
        }
    }
}
