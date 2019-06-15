using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ArmorOn.Models
{
    public class ContactModel
    {
        [Required]
        [Display(Name = "Full Name")]
        public string FullName { get; set; }
        [Required]
        [Display(Name = "Email Address")]
        [EmailAddress]
        public string EmailAddress { get; set; }
        [Required]
        [Display(Name = "How many customized uniforms would you like to order?*")]
        public int NumberOfUniforms { get; set; }

        [Required]
        [Display(Name = "Mobile Number*")]
        public string MobileNumber { get; set; }

        [Required]
        [Display(Name = "Date Needed (deadline)")]
        public DateTime DateNeeded { get; set; }
        [Required]
        [Display(Name = "Message")]
        public string CustomerMessage { get; set; }
    }
}