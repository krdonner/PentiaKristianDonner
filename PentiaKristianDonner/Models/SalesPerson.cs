using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PentiaKristianDonner.Models
{
    public class SalesPerson
    {
        [Key]
        public string SalesPersonName { get; set; }
        public string JobTitle { get; set; }
        public string Address { get; set; }
        public int Salary { get; set; }
    }
}
