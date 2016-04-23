using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PentiaKristianDonner.Models
{
   public class CarPurchase
    {
        [Key]
        public int CarPurchaseID { get; set; }
        public DateTime OrderDate { get; set; }
        public int PricePaid { get; set; }
        public int CarID { get; set; }
        public int CustomerID { get; set; }
        public string SalesPersonName { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual SalesPerson SalesPerson { get; set; }
        public virtual Car Car { get; set; }
    }
}
