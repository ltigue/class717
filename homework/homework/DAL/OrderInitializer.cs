using homework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace homework.DAL
{
    public class OrderInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<OrderContext>

    {
        protected override void Seed(OrderContext context)
        {
           
            var customers =new List<Customer>
            {
                new Customer{FirstName="John", LastName="Jones"  },
                new Customer{FirstName="Mary", LastName="Moore" }
            };
                customers.ForEach(c=> context.Customers.Add(c));
            context.SaveChanges();
            var parts = new List<Part>
            {
                new Part{PartID="111", Type="Widget", Price=5.00M},
                new Part{PartID="222", Type="Gadget", Price=2.00M}
            };

            parts.ForEach(c=> context.Parts.Add(c));
            context.SaveChanges();

            var orders = new List<Order>
            {
                new Order{OrderID="190", Date=DateTime.Parse("2013-12-1") },
                new Order{OrderID="200", Date=DateTime.Parse("2014-5-1")}, 
            };
            orders.ForEach(c=> context.Orders.Add(c));
            context.SaveChanges();
            
        }
    }
}