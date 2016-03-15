using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CatTales.Models
{
    public class PostsDbInitializer : DropCreateDatabaseAlways<CatTalesContext>
    {
        Post post = new Post();
        protected override void Seed(CatTalesContext context)
        {
            // Starting date
            DateTime seedDate = new DateTime();
            //DateTime seedDate = new DateTime(2016, 02, 01);

            // Member seed
            //Member mbr01 = new Member { NameFirst = "John", NameLast = "Davis", Email = "jdavis@test.com", UserName = "JohnD", Gender = "M", Birthday = DateTime.Parse("1958-06-02"), ProfPict = "~/Content/images/profile/profile-guy.jpg" };
            //Member mbr02 = new Member { NameFirst = "Barbra", NameLast = "Robins", Email = "brobins@test.com", UserName = "BarbraR", Gender = "F", Birthday = DateTime.Parse("1972-04-12"), ProfPict = "~/Content/images/profile/profile-girl.jpg" };
            //Member mbr03 = new Member { NameFirst = "Connie", NameLast = "White", Email = "conniew@test.com", UserName = "ConnieW", Gender = "F", Birthday = DateTime.Parse("1980-07-15"), ProfPict = "~/Content/images/profile/profile-girl.jpg" };
            //Member mbr04 = new Member { NameFirst = "Shawn", NameLast = "Honda", Email = "shawnh@test.com", UserName = "ShawnH", Gender = "M", Birthday = DateTime.Parse("1988-03-20"), ProfPict = "~/Content/images/profile/profile-guy.jpg" };

            // Post seed
            Post pst01 = new Post { Date = seedDate, UserName = "JohnD", Subject = "Looking for a good claw clipper", Body = "Tobby's claws have been getting wild, but the clippers I've been using are too dull. Anyone have suggestions for a good pair of clippers?" };
            Post pst02 = new Post { Date = seedDate, UserName = "BarbraR", Subject = "Cute cat bowties", Body = "I found an Etsy shop that sells the cutest bowties! It's called Cat Bows, and the bowties go for $6.99 plus shipping. I already got two; Andy may grumble, but he really rocks a good bowtie." };
            Post pst03 = new Post { Date = seedDate, UserName = "ConnieW", Subject = "Simon's Cat Valentine 2016 short", Body = "Have anyone seen the latest Simon's Cat? The cat gets a little too much love from a cute Maine Coon. Poor guy!" };
            Post pst04 = new Post { Date = seedDate, UserName = "ShawnH", Subject = "New cat condo", Body = "I finally finished the cat condo last Saturday. Sam wasn't too impressed, but after some coaxing and bribery he hopped in. Now he practically lives in there." };

            // Reply seed
            //Reply rpy01 = new Reply { Date = seedDate, PostID = 1, MemberID = 2, Body = "Have you tried a scisor-type claw trimmer? They cut a bit better than the clippers, and won't crack the claw."};

            //pst01.Members.Add(mbr01);
            //pst02.Members.Add(mbr02);
            //pst03.Members.Add(mbr03);
            //pst04.Members.Add(mbr04);

            context.Posts.Add(pst01);
            context.Posts.Add(pst02);
            context.Posts.Add(pst03);
            context.Posts.Add(pst04);

            base.Seed(context);
        }
    }
}