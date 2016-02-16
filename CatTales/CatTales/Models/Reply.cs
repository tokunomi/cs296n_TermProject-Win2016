using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CatTales.Models
{
    public class Reply
    {
        public int ReplyID { get; set; }
        public int PostID { get; set; }
        public int MemberID { get; set; }
        public DateTime Date { get; set; }
        public string Body { get; set; }
    }
}