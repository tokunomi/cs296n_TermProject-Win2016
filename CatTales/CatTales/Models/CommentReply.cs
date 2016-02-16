using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CatTales.Models
{
    public class CommentReply
    {
        public int CommentReplyID { get; set; }
        public int CommentID { get; set; }
        public int MemberID { get; set; }
        public DateTime Date { get; set; }
        public string Body { get; set; }
    }
}