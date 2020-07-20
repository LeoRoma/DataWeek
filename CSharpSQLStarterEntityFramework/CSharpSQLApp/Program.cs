using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace CSharpSQLApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new NorthwindContext())
            {
                Console.WriteLine(db.ContextId);

                foreach(var c in db.Customers)
                {
                    Console.WriteLine($"Customer {c.GetFullName()} had ID {c.CustomerId}");
                }
            }

        }
    }
}
