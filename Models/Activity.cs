using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tourist_Agency_MVC.Models
{
    public class Activity
    {
        public int Id { get; set; }
        public string Activity_Name { get; set; }
        public string Activity_Duration { get; set; }
        public string Activity_Available_Season { get; set; }
        public string Activity_Special_Need { get; set; }
        public string Activity_Address { get; set; }

    }
}
