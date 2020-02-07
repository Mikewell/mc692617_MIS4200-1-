using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mc692617_MIS4200.Models
{
    public class Visits
    {

        [Key] public int visitID { get; set; }

        // the next two properties link the Visit to the Vet
        
        public int vetID { get; set; }
        public virtual Vet Vet { get; set; }

        // the next two properties link the Pet to the Visit
        public int petID { get; set; }
        public virtual Pet Pet { get; set; }

        public DateTime dateTime { get; set; }
        public string description { get; set; }



    }
}