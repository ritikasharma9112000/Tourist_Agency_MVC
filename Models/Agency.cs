using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tourist_Agency_MVC.Models
{
    public class Agency
    {
        public int Id { get; set; }
        public string Agency_Name { get; set; }
        public string Agency_Phone { get; set; }
        public string Agency_Address { get; set; }
        public string Agency_Email { get; set; }
        public string Agency_Website { get; set; }
    }
}
