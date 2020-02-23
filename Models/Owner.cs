using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace mc692617_MIS4200.Models
{
    public class Owner
    {
        [Key]
        public int ownerID { get; set; }
        [Display(Name = "First Name")]
        [Required(ErrorMessage ="First Name Required")]
        
        public string firstName { get; set; }
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last Name Required")]
        
        public string lastName { get; set; }
        [Display(Name = "Email")]
        [Required]
        [EmailAddress(ErrorMessage ="Enter Email Address")]
        public string email { get; set; }
        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", 
            ErrorMessage ="(xxx) xxx-xxxx")]
        public string phone { get; set; }
        [Display(Name = "Address")]
        [Required]
        public string address { get; set; }

        
        public ICollection <Pet> Pets { get; set; }







    }
}