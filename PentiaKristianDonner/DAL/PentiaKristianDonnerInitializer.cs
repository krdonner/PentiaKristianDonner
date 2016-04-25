using PentiaKristianDonner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PentiaKristianDonner.DAL
{
   public class PentiaKristianDonnerInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<PentiaKristianDonnerContext>
    {
        protected override void Seed(PentiaKristianDonnerContext context) 
        {

            var cars = new List<Car>
            {
                new Car {Make="BMW", Model="X5 M", Color="Blue Metallic", Extras="Nav", RecommendedPrice=795000 },
                new Car {Make="Mercedes", Model="E63 AMG", Color="Black Metallic", Extras="Bose Sound System", RecommendedPrice=1195000 }
            };
            cars.ForEach(s => context.Cars.Add(s));
            context.SaveChanges();

            var customers = new List<Customer>
            {
                new Customer {Name="Kristian", Surname="Donner", Age=27, Created=DateTime.Now.Date, Address="Ellstorpsgatan 2c" },
                new Customer {Name="Stig", Surname="Helmer", Age=75, Created=DateTime.Now.Date, Address="Kvarngatan 10" }
            };
            customers.ForEach(s => context.Customers.Add(s));
            context.SaveChanges();

            var salesPersons = new List<SalesPerson>
            {
                new SalesPerson {SalesPersonName="Jason Bateman", JobTitle="Manager", Address="Långgatan 2c", Salary=450000 },
                new SalesPerson {SalesPersonName="Christian Bale", JobTitle="Employee", Address="KortGatan 12a", Salary=19000 }

            };
            salesPersons.ForEach(s => context.SalesPersons.Add(s));
            context.SaveChanges();

            var carPurchases = new List<CarPurchase>
            {
                new CarPurchase {OrderDate=DateTime.Now.Date, PricePaid=795000, CustomerID=1, SalesPersonName="Jason Bateman", CarID=1 },
                new CarPurchase {OrderDate=DateTime.Now.Date, PricePaid=1195000, CustomerID=2, SalesPersonName="Christian Bale", CarID=2}

            };
            carPurchases.ForEach(s => context.CarPurchases.Add(s));
            context.SaveChanges();

        }
    }
}
