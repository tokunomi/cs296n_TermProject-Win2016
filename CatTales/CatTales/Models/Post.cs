using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CatTales.Models
{
    public class Post
    {
        List<Reply> reply = new List<Reply>();

        public int PostID { get; set; }
        public int MemberID { get; set; }
        public List<Reply> Replies 
        { 
            get { return reply; }
        }
        public DateTime Date { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}