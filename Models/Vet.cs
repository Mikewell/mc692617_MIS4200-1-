using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mc692617_MIS4200.Models
{
    public class Vet
    {
        public int vetID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public DateTime employeeSince { get; set; }


        public ICollection<Pet> Pet { get; set; }
    }
}