using System.Collections.Generic;
using System.Linq;
using CodeFromNorthwindModel;

namespace CodeFromNorthwindBusiness
{
    public class CRUDManager
    {
        public Customers SelectedCustomer { get; set;}
    
        public void Create()
        {
        }

        public void Update(string customerId, string contactName, string city, string postcode, string country)
        {
            using (var db = new NorthwindContext())
            {
                SelectedCustomer = db.Customers.Where(c => c.CustomerId == customerId).FirstOrDefault();
                SelectedCustomer.ContactName = contactName;
                SelectedCustomer.City = city;
                SelectedCustomer.PostalCode = postcode;
                SelectedCustomer.Country = country;
                // write changes to database
                db.SaveChanges();
            }
        }

        public void Delete()
        {

        }

        public List<Customers> RetrieveAll()
        {
            using (var db = new NorthwindContext())
            {
                return db.Customers.ToList();
            }
        }

        public void SetSelectedCustomer(object selectedItem)
        {
            SelectedCustomer = (Customers)selectedItem;
        }
    }
}
