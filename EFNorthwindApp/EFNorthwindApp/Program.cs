using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace EFNorthwindApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new NorthwindContext())
            {
                //var orderQuery =
                //from order in db.Orders
                //where order.Freight > 750
                //select order;

                //foreach (var order in orderQuery)
                //{
                //    Console.WriteLine($"{order.CustomerId} paid {order.Freight} for shipping to {order.ShipCity}");
                //}

                //Joining table with method .Include()
                //var orderQuerywithCust =
                //    from order in db.Orders.Include(o => o.Customer)
                //    where order.Freight > 750
                //    select order;

                //foreach (var order in orderQuerywithCust)
                //{
                //    if (order.Customer != null)
                //        Console.WriteLine($" {order.Customer.ContactName} of {order.Customer.City} paid {order.Freight} for shipping");
                //}

                ////Joining Table with normal query
                //var orderQueryUsingInnerJoin =
                //    from order in db.Orders
                //    where order.Freight > 750
                //    join customer in db.Customers on order.CustomerId equals customer.CustomerId
                //    select new { CustomerContactName = customer.ContactName, City = customer.City, Freight = order.Freight };

                //foreach (var result in orderQueryUsingInnerJoin)
                //{
                //    Console.WriteLine($"{result.CustomerContactName} of {result.City} paid {result.Freight} for shipping");
                //}

                // 1.1 Query1
                //var allCustomersParisLondon =
                //    from customer in db.Customers
                //    select customer;

                //foreach (var customer in allCustomersParisLondon)
                //{
                //    if (customer.City == "London" || customer.City == "Paris")
                //        Console.WriteLine($"{customer.CompanyName}, {customer.Address}, {customer.City}, {customer.PostalCode}, {customer.Country}");
                //    //Console.WriteLine(customer.ContactName);
                //}

                //1.1 Query2
                //var allCustomerParisLondonSQL =
                //    from customer in db.Customers
                //    where customer.City == "London" || customer.City == "Paris"
                //    select customer;

                //foreach (var customer in allCustomerParisLondonSQL)
                //{
                //    Console.WriteLine($"{customer.CompanyName}, {customer.Address}, {customer.City}, {customer.PostalCode}, {customer.Country}");
                //}

                //1.1 Method
                //var allCustomerParisLondon = from customer in db.Customers.Where(c => c.City == "London" || c.City == "Paris")
                //                             select customer;

                //foreach (var customer in allCustomerParisLondon)
                //{
                //    Console.WriteLine($"{customer.CompanyName}, {customer.Address}, {customer.City}, {customer.PostalCode}, {customer.Country}");
                //}

                //1.2 Query1
                //var allBottles1 =
                //    from product in db.Products
                //    select product;

                //foreach (var product in allBottles1)
                //{
                //    if (product.QuantityPerUnit.Contains("bottles"))
                //        Console.WriteLine($"{product.ProductName}, {product.QuantityPerUnit}");
                //}

                //1.2 Query2
                //var allBottles2 =
                //    from product in db.Products
                //    where product.QuantityPerUnit.Contains("Bottles")
                //    select product;

                //foreach(var product in allBottles2)
                //{
                //    Console.WriteLine($"{product.ProductName}, {product.ProductName}");
                //}

                //1.2 Method
                //var allBottles3 = from product in db.Products.Where(p => p.QuantityPerUnit.Contains("Bottles"))
                //                  select product;

                //foreach (var product in allBottles3)
                //{
                //    Console.WriteLine($"{product.ProductName}, {product.ProductName}");
                //}

                //1.3 Query
                //var allBottlesSupplier =
                //    from product in db.Products
                //    where product.QuantityPerUnit.Contains("Bottles")
                //    join supplier in db.Suppliers on product.SupplierId equals supplier.SupplierId
                //    select new { SupplierCompanyName = supplier.CompanyName, SupplierCountry = supplier.CompanyName, ProductQuantityPerUnity = product.QuantityPerUnit };

                //foreach (var product in allBottlesSupplier)
                //{
                //    Console.WriteLine($"{product.SupplierCompanyName}, {product.SupplierCountry}, {product.ProductQuantityPerUnity}");
                //}

                //1.3 Method //Joining table with method .Include()
                //var allBottlesSupplier = from product in db.Products.Include(p => p.Supplier).Where(p => p.QuantityPerUnit.Contains("Bottles"))
                //                        select product;

                //foreach (var product in allBottlesSupplier)
                //{
                //    Console.WriteLine($"{product.Supplier.CompanyName}, {product.Supplier.Country}, {product.QuantityPerUnit}");
                //}

                //1.4 Query
                //var categoryNames =
                //    from product in db.Products
                //    join category in db.Categories on product.CategoryId equals category.CategoryId
                //    select category;

                //var uniqueCategoryNames = new List<string>();
                //foreach (var category in categoryNames)
                //{
                //    uniqueCategoryNames.Add(category.CategoryName);
                //}
                //var count = uniqueCategoryNames.GroupBy(x => x).Select(g => new { key = g.Key, count = g.Count() }).ToList();
                //foreach (var item in count)
                //{
                //    Console.WriteLine($"{item.count}, {item.key}");
                //}

                //1.5 query 
                //var employees =
                //    from employee in db.Employees
                //    where employee.Country == "UK"
                //    select employee;

                //foreach (var employee in employees)
                //{
                //    Console.WriteLine($"{ employee.TitleOfCourtesy} {employee.FirstName} {employee.LastName}, {employee.City}");
                //}

                //1.5 Method
                //var employees =
                //    from employee in db.Employees.Where(e => e.City == "London")
                //    select employee;
                //foreach (var employee in employees)
                //{
                //    Console.WriteLine($"{ employee.TitleOfCourtesy} {employee.FirstName} {employee.LastName}, {employee.City}");
                //}

                //1.6

            }

        }
    }
}
