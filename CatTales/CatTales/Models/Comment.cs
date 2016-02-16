using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CatTales.Models
{
    public class Comment
    {
        List<CommentReply> cReply = new List<CommentReply>();
        public int CommentID { get; set; }
        public int ArticleID { get; set; }
        public int MemberID { get; set; }

        public List<CommentReply> CommentReplies 
        { 
            get { return cReply; } 
        }
        public DateTime Date { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }
}