using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mc692617_MIS4200.Models
{
    public class Owner
    {
        public int ownerID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public DateTime customerSince { get; set; }




        public ICollection<petDetail> petDetail { get; set; }
    }
}