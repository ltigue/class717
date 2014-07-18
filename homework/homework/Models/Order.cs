using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace homework.Models
{
    public class Order
    {
        
        public string OrderID { get; set; }
        public DateTime Date { get; set; }
        public decimal Price { get; set; }
        public string Items { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<Part> Parts { get; set; }
    }
}