using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mc692617_MIS4200.Models
{
    public class Customer
    {
        [Key]
        public int customerID { get; set; }
        public int customerFirstName { get; set; }
        public int customerLastName { get; set; }
        public int email { get; set; }
        public int phone { get; set; }
        public int customerSince { get; set; }
        public ICollection<Orders> Order { get; set; }
    }
}