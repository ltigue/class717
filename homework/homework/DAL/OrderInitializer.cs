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
            base.Seed(context);
            var customers =new List<Customer>
            {
                new Customer{FirstName="John", LastName="Jones", OrderDate=DateTime.Parse("2013-12-1") },
                new Customer{FirstName="Mary", LastName="Moore", OrderDate=DateTime.Parse("2014-5-1")}
            };
                customers.ForEach(c=> context.Customers.Add(c));
            context.SaveChanges();
            var parts = new List<Part>
            {
                new Part{PartID=111, PartName="Widget", Price=5.00},
                new Part{PartID=222, PartName="Gadget", Price=2.00}
            };

            parts.ForEach(c=> context.Parts.Add(c));
            context.SaveChanges();
            }
        }
    }
}