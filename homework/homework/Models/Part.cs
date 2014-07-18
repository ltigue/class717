using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace homework.Models
{
    public class Part
    {
        public string PartID { get; set; }
        public string Type { get; set; }
        public decimal Price { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}