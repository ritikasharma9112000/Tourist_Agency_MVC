
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tourist_Agency_MVC.Models
{
    public class Package
    {
        public int Id { get; set; }
        public decimal Package_Price { get; set; }
        public int ActivityId { get; set; }
        public Activity Activity { get; set; }
        public int AgencyId { get; set; }
        public Agency Agency { get; set; }


    }
}
