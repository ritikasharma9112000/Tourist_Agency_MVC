
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tourist_Agency_MVC.Models
{
    public class Packages
    {
        public int Id { get; set; }
        public decimal Package_Price { get; set; }
        public int Activity_Id { get; set; }
        public Activities Activity { get; set; }
        public int Agency_Id { get; set; }
        public Agency Agency { get; set; }


    }
}
