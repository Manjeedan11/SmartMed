using System;
using System.Collections.Generic;
using System.Text;

namespace SmartMed.Models
{
    public class User
    {
        public int userId { get; set; }
        public string email { get; set; }
        public string passwordHash { get; set; }
        public string role { get; set; }
        public DateTime createdAt { get; set; }
    }
}
