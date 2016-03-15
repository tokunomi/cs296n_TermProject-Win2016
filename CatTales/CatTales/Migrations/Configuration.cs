namespace CatTales.Migrations
{
    using CatTales.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CatTales.Models.CatTalesContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "CatTales.Models.CatTalesContext";
        }

        protected override void Seed(CatTales.Models.CatTalesContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            /* For testing */
            // runs a debugger in a seperate instance of VisualStudio
            if (System.Diagnostics.Debugger.IsAttached == false)
                System.Diagnostics.Debugger.Launch();
            

            // Usermanager
            UserManager<Member> userManager = new UserManager<Member>(new UserStore<Member>(context));

            // For the initial seed only. Comment out later
            var user = new Member { UserName = "admin", NameFirst = "Admin", NameLast = "Istrator", Email = "test@test.com" };
            var result = userManager.Create(user, "testing");

            // Add a role
            context.Roles.Add(new IdentityRole() { Name = "Admin" });
            context.SaveChanges();

            // Following is from MembersDbInitializer
            // Starting date
            DateTime? seedDate = new DateTime(2016, 02, 01);

            // Member seed
            Member usr01 = new Member { NameFirst = "John", NameLast = "Davis", Email = "jdavis@test.com", UserName = "JohnD", Gender = "M", Birthday = DateTime.Parse("06-02-1958"), ProfPict = "~/Content/images/profile/profile-guy.jpg" };
            var rltuser01 = userManager.Create(usr01, "testing");
            Member usr02 = new Member { NameFirst = "Barbra", NameLast = "Robins", Email = "brobins@test.com", UserName = "BarbraR", Gender = "F", Birthday = DateTime.Parse("04-12-1972"), ProfPict = "~/Content/images/profile/profile-girl.jpg" };
            var rltuser02 = userManager.Create(usr02, "testing");
            Member usr03 = new Member { NameFirst = "Connie", NameLast = "White", Email = "conniew@test.com", UserName = "ConnieW", Gender = "F", Birthday = DateTime.Parse("07-15-1980"), ProfPict = "~/Content/images/profile/profile-girl.jpg" };
            var rltuser03 = userManager.Create(usr03, "testing");
            Member usr04 = new Member { NameFirst = "Shawn", NameLast = "Honda", Email = "shawnh@test.com", UserName = "ShawnH", Gender = "M", Birthday = DateTime.Parse("03-20-1988"), ProfPict = "~/Content/images/profile/profile-guy.jpg" };
            var rltuser04 = userManager.Create(usr04, "testing");

            // Cat seed
            Cat cat01 = new Cat { Name = "Tiger", Breed = "Abyssinian", Age = "3", Gender = "M", Color = "Fawn" };
            Cat cat02 = new Cat { Name = "Diana", Breed = "Pursian", Age = "5", Gender = "F", Color = "White" };
            Cat cat03 = new Cat { Name = "Patty", Breed = "Mixed", Age = "6", Gender = "F", Color = "Calico" };
            Cat cat04 = new Cat { Name = "Sam", Breed = "Maine Coon", Age = "4", Gender = "M", Color = "Silver Tabby" };

            usr01.Cats.Add(cat01);
            usr02.Cats.Add(cat02);
            usr03.Cats.Add(cat03);
            usr04.Cats.Add(cat04);

            context.Users.AddOrUpdate(usr01);
            context.Users.AddOrUpdate(usr02);
            context.Users.AddOrUpdate(usr03);
            context.Users.AddOrUpdate(usr04);
            context.SaveChanges();
        }
    }
}
