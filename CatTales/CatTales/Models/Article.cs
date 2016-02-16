using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CatTales.Models
{
    public class Article
    {
        public int ArticleID { get; set; }
        public int AuthorID { get; set; }
        public DateTime Date { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string Graphic { get; set; }
    }
}