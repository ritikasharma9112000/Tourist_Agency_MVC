using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tourist_Agency_MVC.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public int Customer_Id { get; set; }
        public Customer Customer { get; set; }
        public int Package_Id { get; set; }
        public Packages package { get; set; } 
        public DateTime Date_Of_Booking { get; set; }

        
    }
}
