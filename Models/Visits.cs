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
        [Display(Name = "Veterinarian")]
        [Required(ErrorMessage = "Select which Veterinarian cared for the dog")]
        
        public int vetID { get; set; }
        public virtual Vet Vet { get; set; }

        // the next two properties link the Pet to the Visit
        [Display(Name = "Pet")]
        [Required(ErrorMessage = "Select which pet was cared for today")]
     
        public int petID { get; set; }
        public virtual Pet Pet { get; set; }

        [Display(Name = "Date")]
        [Required(ErrorMessage = "Enter date of which service was performed")]
        
        public DateTime dateTime { get; set; }
        [Display(Name = "Description")]
        [Required(ErrorMessage = "Enter a description of the visit")]
       
        public string description { get; set; }



    }
}