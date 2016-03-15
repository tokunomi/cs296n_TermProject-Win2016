using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CatTales.Models
{
    public class MembersDbInitializer : DropCreateDatabaseIfModelChanges<CatTalesContext>
    //public class MembersDbInitializer : DropCreateDatabaseAlways<CatTalesContext>
    {
        Member member = new Member();

        protected override void Seed(CatTalesContext context)
        {
            // Starting date
            DateTime? seedDate = new DateTime(2016, 02, 01);

            // Member seed
            Member mbr01 = new Member { NameFirst = "John", NameLast = "Davis", Email = "jdavis@test.com", UserName = "JohnD", Gender = "M", Birthday = DateTime.Parse("06-02-1958"), ProfPict = "~/Content/images/profile/profile-guy.jpg" };
            Member mbr02 = new Member { NameFirst = "Barbra", NameLast = "Robins", Email = "brobins@test.com", UserName = "BarbraR", Gender = "F", Birthday = DateTime.Parse("04-12-1972"), ProfPict = "~/Content/images/profile/profile-girl.jpg" };
            Member mbr03 = new Member { NameFirst = "Connie", NameLast = "White", Email = "conniew@test.com", UserName = "ConnieW", Gender = "F", Birthday = DateTime.Parse("07-15-1980"), ProfPict = "~/Content/images/profile/profile-girl.jpg" };
            Member mbr04 = new Member { NameFirst = "Shawn", NameLast = "Honda", Email = "shawnh@test.com", UserName = "ShawnH", Gender = "M", Birthday = DateTime.Parse("03-20-1988"), ProfPict = "~/Content/images/profile/profile-guy.jpg" };

            // Cat seed
            Cat cat01 = new Cat { Name = "Tiger", Breed = "Abyssinian", Age = "3", Gender = "M", Color = "Fawn" };
            Cat cat02 = new Cat { Name = "Diana", Breed = "Pursian", Age = "5", Gender = "F", Color = "White" };
            Cat cat03 = new Cat { Name = "Patty", Breed = "Mixed", Age = "6", Gender = "F", Color = "Calico" };
            Cat cat04 = new Cat { Name = "Sam", Breed = "Maine Coon", Age = "4", Gender = "M", Color = "Silver Tabby" };


            mbr01.Cats.Add(cat01);
            mbr02.Cats.Add(cat02);
            mbr03.Cats.Add(cat03);
            mbr04.Cats.Add(cat04);

            context.Users.Add(mbr01);
            context.Users.Add(mbr02);
            context.Users.Add(mbr03);
            context.Users.Add(mbr04);


            base.Seed(context);
        }
    }
}