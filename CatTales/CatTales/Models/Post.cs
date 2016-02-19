using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CatTales.Models
{
    public class Post
    {
        List<Reply> reply = new List<Reply>();
        List<Member> member = new List<Member>();

        public int PostID { get; set; }
        public int MemberID { get; set; }
        public List<Reply> Replies 
        { 
            get { return reply; }
        }
        public List<Member> Members
        {
            get { return member; } 
        }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        [StringLength(30)]
        public string Username { get; set; }  // this should be the username from Memebers
        [StringLength(50)]
        public string Subject { get; set; }
        [DataType(DataType.MultilineText)]
        [StringLength(500)]
        public string Body { get; set; }
    }
}