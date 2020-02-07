using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mc692617_MIS4200.Models
{
    public class Pet
    {
        [Key] public int petID { get; set; }
        public string name { get; set; }
        public DateTime birthday { get; set; }
        public string breed { get; set; }
        public string weight { get; set; }
        public string height { get; set; }
        public int trackingNumber { get; set; }

        public ICollection <Visits> Visits { get; set; }
        // the next two properties link the Pet to the Visit
        public int ownerID { get; set; }
        public virtual Owner Owner { get; set; }



    }
}