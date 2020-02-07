using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mc692617_MIS4200.Models
{
    public class petDetail
    {
        public int petDetailID { get; set; }
        public string weight { get; set; }
        public string breed { get; set; }
        public DateTime lastVisit { get; set; }
        // the next two properties link the orderDetail to the Order
        public int petID { get; set; }
        public virtual Pet Pet { get; set; }
        // the next two properties link the orderDetail to the Product
        public int ownerID { get; set; }
        public virtual Owner Owner { get; set; }
    }
}