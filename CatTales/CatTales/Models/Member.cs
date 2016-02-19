using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CatTales.Models
{
    public class Member
    {
        List<Cat> cat = new List<Cat>();
        public int MemberID { get; set; }
        public List<Cat> Cats 
        { 
            get { return cat; }
        }

        [Required]
        [StringLength(50)]
        [Display(Name = "First Name", Order = 15000)]
        public string NameFirst { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 2)]
        [Display(Name = "Last Name", Order = 15001)]
        public string NameLast { get; set; }
        [StringLength(30)]
        public string Username { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Please check your Email Address; it does not appear valid.")]
        public string Email { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Birthday { get; set; }
        [StringLength(1)]
        public string Gender { get; set; }  // planning to make this a pulldown
        [DataType(DataType.Url)]
        public string Website { get; set; }

        // TODO: Profile picture; not sure what datatype it should be. 
        // String for now so that a link to a graphic could be added to it.
        [DataType(DataType.ImageUrl)]
        public string ProfPict { get; set; }
    }
}