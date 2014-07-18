using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace homework.Models
{
    public class Order
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string OrderID { get; set; }
        public string Date { get; set; }
        public int DateTime { get; set; }
        public decimal Price { get; set; }
        public string Items { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<Part> Parts { get; set; }
    }
}