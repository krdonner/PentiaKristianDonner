using PentiaKristianDonner.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PentiaKristianDonner.DAL
{
   public class PentiaKristianDonnerContext : DbContext
    {
        public PentiaKristianDonnerContext() : base("PentiaKristianDonnerContext")
        {

        }
        public DbSet<SalesPerson> SalesPersons { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CarPurchase> CarPurchases { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}
