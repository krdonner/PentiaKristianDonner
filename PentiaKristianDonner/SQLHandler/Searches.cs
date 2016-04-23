using PentiaKristianDonner.DAL;
using PentiaKristianDonner.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PentiaKristianDonner.SQLHandler
{
    public class Searches
    {
        private PentiaKristianDonnerContext db = new PentiaKristianDonnerContext();

        public List<Customer> SearchByName(string searchString)
        {
            var customers = from s in db.Customers select s;
            customers = customers.Where(s => s.Name.Contains(searchString));

            return customers.ToList();

        }

        public List<Customer> SearchByAddress(string searchString)
        {
            var customers = from s in db.Customers select s;
            customers = customers.Where(s => s.Address.Contains(searchString));

            return customers.ToList();
        }

        public List<Customer> SearchByMake(string searchString)
        {

            var customers = new List<Customer>();
            var a =
                from x in db.Cars
                where x.Make == searchString
                select x.CarID;
            foreach (var carID in a)
            {
                var q =
                    from o in db.CarPurchases
                    where o.CarID == carID
                    select o.CustomerID;
                foreach (var custID in q)
                {
                    var s =
                        from o in db.Customers
                        where o.CustomerID == custID
                        select o;
                    foreach (var cust in s)
                    {
                        var cl = new Customer
                        {
                            Name = cust.Name,
                            Surname = cust.Surname,
                            Address = cust.Address,
                            Age = cust.Age,
                            Created = cust.Created
                        };
                        customers.Add(cl);
                    }

                }
            }
            return customers.ToList();
        }

        public List<Customer> SearchByModel(string searchString)
        {

            var customers = new List<Customer>();
            var a =
                from x in db.Cars
                where x.Model == searchString
                select x.CarID;
            foreach (var carID in a)
            {
                var q =
                    from o in db.CarPurchases
                    where o.CarID == carID
                    select o.CustomerID;
                foreach (var custID in q)
                {
                    var s =
                        from o in db.Customers
                        where o.CustomerID == custID
                        select o;
                    foreach (var cust in s)
                    {
                        var cl = new Customer
                        {
                            Name = cust.Name,
                            Surname = cust.Surname,
                            Address = cust.Address,
                            Age = cust.Age,
                            Created = cust.Created
                        };
                        customers.Add(cl);
                    }

                }
            }
            return customers.ToList();
        }

        public List<Customer> SearchBySalesPerson(string searchString)
        {

            var customers = new List<Customer>();
            var a =
                from x in db.CarPurchases
                where x.SalesPersonName == searchString
                select x.CustomerID;
            foreach (var custID in a)
            {
                var q =
                    from o in db.Customers
                    where o.CustomerID == custID
                    select o;
                foreach (var customer in q)
                {
                    var cl = new Customer
                    {
                        Name = customer.Name,
                        Surname = customer.Surname,
                        Address = customer.Address,
                        Age = customer.Age,
                        Created = customer.Created
                    };
                    customers.Add(cl);


                }
            }
            return customers.ToList();
        }
    }
}
