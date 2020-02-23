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
        [Display(Name = "Name")]
        [Required(ErrorMessage = "Name Required")]
        
        public string name { get; set; }
        [Display(Name = "Birthday")]
        [Required(ErrorMessage = "Enter dog's birthday")]
       
        public DateTime birthday { get; set; }
        [Display(Name = "Breed")]
        [Required(ErrorMessage = "Enter dog's breed")]
       
        public string breed { get; set; }
        [Display(Name = "Weight")]
        [Required(ErrorMessage = "Enter dog's weight")]
       
        public string weight { get; set; }
        [Display(Name = "Height")]
        [Required(ErrorMessage = "Enter dog's weight")]
       
        public string height { get; set; }
        [Display(Name = "Tracking Number")]
        [Required(ErrorMessage = "Enter dog's tracking number")]
        
        public int trackingNumber { get; set; }

        [Display(Name = "VisitID")]
        public ICollection <Visits> Visits { get; set; }
        // the next two properties link the Pet to the Visit
        [Display(Name = "Owner")]
        public int ownerID { get; set; }
        public virtual Owner Owner { get; set; }



    }
}