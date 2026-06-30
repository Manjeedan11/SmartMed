using System;
using System.Collections.Generic;
using System.Text;

namespace SmartMed.Models
{
    public class Customer : User
    {
        public int customerId { get; set; }
        public string fullName { get; set; }
        public string phoneNumber { get; set; }
        public string address { get; set; }
    }
}
