namespace PentiaKristianDonner.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PentiaKristianDonner.DAL.PentiaKristianDonnerContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "PentiaKristianDonner.DAL.PentiaKristianDonnerContext";
        }

        protected override void Seed(PentiaKristianDonner.DAL.PentiaKristianDonnerContext context)
        {
            var cars = new List<Car>
            {
                new Car {Make="BMW", Model="X5 M", Color="Blue Metallic", Extras="Nav", RecommendedPrice=795000 },
                new Car {Make="Mercedes", Model="E63 AMG", Color="Black Metallic", Extras="Bose Sound System", RecommendedPrice=1195000 },
                new Car {Make="Toyota", Model="Avensis", Color="Grey Metallic", Extras="N/A", RecommendedPrice=347000 },
                new Car {Make="Volkswagen", Model="Passat", Color="White", Extras="Steering wheel", RecommendedPrice=289000 },
            };
            cars.ForEach(s => context.Cars.AddOrUpdate(p=>p.Model, s));
            context.SaveChanges();

            var customers = new List<Customer>
            {
                new Customer {Name="Kristian", Surname="Donner", Age=27, Created=DateTime.Now.Date, Address="Ellstorpsgatan 2c" },
                new Customer {Name="Stig", Surname="Helmer", Age=75, Created=DateTime.Now.Date, Address="Kvarngatan 10" },
                new Customer {Name="Lars", Surname="Svensson", Age=35, Created=DateTime.Now.Date, Address="Lillegatan 13" }
            };
            customers.ForEach(s => context.Customers.AddOrUpdate(p=>p.Name, s));
            context.SaveChanges();

            var salesPersons = new List<SalesPerson>
            {
                new SalesPerson {SalesPersonName="Jason Bateman", JobTitle="Manager", Address="Långgatan 2c", Salary=450000 },
                new SalesPerson {SalesPersonName="Christian Bale", JobTitle="Employee", Address="KortGatan 12a", Salary=19000 },
                new SalesPerson {SalesPersonName="Jason Statham", JobTitle="MVP", Address="VästGatan 12a", Salary=24000 }

            };
            salesPersons.ForEach(s => context.SalesPersons.AddOrUpdate(p => p.SalesPersonName, s));
            context.SaveChanges();

            var carPurchases = new List<CarPurchase>
            {
                new CarPurchase {OrderDate=DateTime.Now, PricePaid=795000, CustomerID=1, SalesPersonName="Jason Bateman", CarID=1 },
                new CarPurchase {OrderDate=DateTime.Now, PricePaid=1195000, CustomerID=2, SalesPersonName="Christian Bale", CarID=2},
                new CarPurchase {OrderDate=DateTime.Now, PricePaid=1195000, CustomerID=3, SalesPersonName="Christian Bale", CarID=2},
                new CarPurchase {OrderDate=DateTime.Now, PricePaid=347000, CustomerID=2, SalesPersonName="Jason Statham", CarID=3},
                new CarPurchase {OrderDate=DateTime.Now, PricePaid=289000, CustomerID=1, SalesPersonName="Jason Bateman", CarID=4}


            };
            carPurchases.ForEach(s => context.CarPurchases.AddOrUpdate(p=> p.OrderDate, s));
            context.SaveChanges(); 
        }
    }
}
