using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace CodeFromNorthwindModel
{
    class Program
    {
        public static void Main(string[] args)
        {
            using (var db = new NorthwindContext())
            {
                var orderQuery =
                from order in db.Orders
                where order.Freight > 750
                select order;

                foreach (var order in orderQuery)
                {
                    Console.WriteLine($"{order.CustomerId} paid {order.Freight} for shipping to {order.ShipCity}");
                }

                var orderQuerywithCust =
                    from order in db.Orders.Include(o => o.Customer)
                    where order.Freight > 750
                    select order;
                Console.WriteLine();
                foreach (var order in orderQuerywithCust)
                {
                    if (order.Customer != null)
                        Console.WriteLine($" {order.Customer.ContactName} of {order.Customer.City} paid {order.Freight} for shipping");
                }

                var orderQuerywithCustMethod = db.Orders.Where(o => o.Freight > 750).Include(o => o.Customer);

                Console.WriteLine();
                foreach (var order in orderQuerywithCustMethod)
                {
                    if (order.Customer != null)
                        Console.WriteLine($" {order.Customer.ContactName} of {order.Customer.City} paid {order.Freight} for shipping");
                }
            }
        }
    }
}
