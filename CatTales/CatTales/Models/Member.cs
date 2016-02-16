using System;
using System.Collections.Generic;
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
        public string NameF { get; set; }
        public string NameL { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public DateTime Birthday { get; set; }
        public string Gender { get; set; }
        public string Website { get; set; }

        // TODO: Profile picture; not sure what datatype it should be. 
        // String for now so that a link to a graphic could be added to it.
        public string ProfPict { get; set; }
    }
}