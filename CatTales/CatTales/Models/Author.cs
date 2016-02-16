using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CatTales.Models
{
    public class Author
    {
        List<Article> article = new List<Article>();
        public int AuthorID { get; set; }
        //public int ArticleID { get; set; }
        public List<Article> Articles 
        {
            get { return article; } 
        }
        public string NameF { get; set; }
        public string NameL { get; set; }
    }
}