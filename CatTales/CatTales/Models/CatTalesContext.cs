using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CatTales.Models
{
    //public class CatTalesContext : DbContext  // original context
    public class CatTalesContext : IdentityDbContext<Member>
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public CatTalesContext() : base("name=CatTalesContext") // original base
        //public CatTalesContext() : base("DefaultConnection")
        {
        }

        public System.Data.Entity.DbSet<CatTales.Models.Post> Posts { get; set; }
        //public System.Data.Entity.DbSet<CatTales.Models.Member> Members { get; set; }  // DEACTIVATED: Will be using Identity.EntityFramework
    
    }
}
