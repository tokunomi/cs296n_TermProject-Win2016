using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CatTales.Models
{
    public class AuthRegisterViewModel
    {
        [Required]
        [StringLength(50)]
        //[Display(Name = "First Name", Order = 15000)]
        [Display(Name = "First Name")]
        public string NameFirst { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        //[Display(Name = "Last Name", Order = 15001)]
        [Display(Name = "Last Name")]
        public string NameLast { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Please check your Email Address; it does not appear valid.")]
        public string Email { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}