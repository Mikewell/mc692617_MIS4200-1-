using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mc692617_MIS4200.Models
{
    public class Vet
    {

        [Key]
        [Display(Name = "Vet Name")]
        public int vetID { get; set; }

        public string fullName { get { return lastName + ", " + firstName; } }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First Name Required")]
      
        public string firstName { get; set; }
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last Name Required")]
        
        public string lastName { get; set; }
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Email Required")]
     
        public string email { get; set; }
        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
            ErrorMessage = "(xxx) xxx-xxxx")]
        public string phone { get; set; }
        [Display(Name = "Date Hired")]
        [Required(ErrorMessage = "Enter when the vet was  hired")]
       
        public DateTime employeeSince { get; set; }

        // the next two properties link the Vet to their previous visits
        public ICollection <Visits> Visits { get; set; }


    }
}