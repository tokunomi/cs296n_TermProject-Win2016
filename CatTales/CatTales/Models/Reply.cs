using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CatTales.Models
{
    public class Reply
    {
        public int ReplyID { get; set; }
        public int PostID { get; set; }
        public int MemberID { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        [DataType(DataType.MultilineText)]
        [StringLength(500)]
        public string Body { get; set; }
    }
}