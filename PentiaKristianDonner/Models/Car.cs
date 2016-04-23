using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PentiaKristianDonner.Models
{
   public class Car
    {
        [Key]
        public int CarID { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int RecommendedPrice { get; set; }
        public string Extras { get; set; }
    }
}
