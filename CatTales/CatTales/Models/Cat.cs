using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CatTales.Models
{
    public class Cat
    {
        public int CatID { get; set; }
        public int MemberID { get; set; }
        public string Name { get; set; }
        public string Breed { get; set; }
        public string Color { get; set; }
        public string Age { get; set; }
        public string Gender { get; set; }

        // TODO: Profile picture; like the Member profile picture, not sure what datatype should be 
        // for a graphic. Set to string for now so that a link to a graphic could be added to it.
        public string ProfPict { get; set; }
    }
}