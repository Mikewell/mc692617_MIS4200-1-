using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mc692617_MIS4200.Models
{
    public class Vet
    {

        [Key] public int vetID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public DateTime employeeSince { get; set; }

        // the next two properties link the Vet to their previous visits
        public ICollection <Visits> Visits { get; set; }


    }
}