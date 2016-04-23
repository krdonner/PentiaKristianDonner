using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PentiaKristianDonner.Models
{
   public class Customer
    {
        [Key]
        public int CustomerID { get; set; }
        public string Address { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public DateTime Created { get; set; }


        public virtual ICollection<CarPurchase> CarPurchases { get; set; }
    }
}
