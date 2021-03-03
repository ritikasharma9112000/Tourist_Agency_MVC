using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tourist_Agency_MVC.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Customer_Name { get; set; }
        public string Customer_Phone { get; set; }
        public string Customer_Email { get; set; }
        public string Customer_Address { get; set; }
    }
}
