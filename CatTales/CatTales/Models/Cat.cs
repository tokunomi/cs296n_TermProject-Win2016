using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CatTales.Models
{
    public class Cat
    {
        List<Member> member = new List<Member>();

        public int CatID { get; set; }
        public int MemberID { get; set; }
        [StringLength(40)]
        public string Name { get; set; }
        [StringLength(15)]
        public string Breed { get; set; }  // may turn this into a pulldown
        [StringLength(20)]
        public string Color { get; set; }
        [StringLength(3, MinimumLength = 1)]
        public string Age { get; set; }
        [StringLength(1)]
        public string Gender { get; set; }

        // TODO: Profile picture; like the Member profile picture, not sure what datatype should be 
        // for a graphic. Set to string for now so that a link to a graphic could be added to it.
        [DataType(DataType.ImageUrl)]
        public string ProfPict { get; set; }

        public virtual Member Member { get; set; }
    }
}