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
            DateTime seedDate = new DateTime(2016, 02, 01);

            // Member seed
            Member mbr01 = new Member { NameFirst = "John", NameLast = "Davis", Email = "jdavis@test.com", Username = "JohnD", Gender = "M", Birthday = DateTime.Parse("1958-06-02") };
            Member mbr02 = new Member { NameFirst = "Barbra", NameLast = "Robins", Email = "brobins@test.com", Username = "BarbraR", Gender = "F", Birthday = DateTime.Parse("1972-04-12") };
            Member mbr03 = new Member { NameFirst = "Connie", NameLast = "White", Email = "conniew@test.com", Username = "ConnieW", Gender = "F", Birthday = DateTime.Parse("1980-07-15") };

            // Post seed
            Post pst01 = new Post { Date = seedDate, Username = "JohnD", Subject = "Looking for a good claw clipper", Body = "Tobby's claws have been getting wild, but the clippers I've been using are too dull. Anyone have suggestions for a good pair of clippers?" };
            Post pst02 = new Post { Date = seedDate, Username = "BarbraR", Subject = "Cute cat bowties", Body = "I found an Etsy shop that sells the cutest bowties! It's called Cat Bows, and the bowties go for $6.99 plus shipping. I already got two; Andy may grumble, but he really rocks a good bowtie." };
            Post pst03 = new Post { Date = seedDate, Username = "ConnieW", Subject = "Simon's Cat Valentine 2016 short", Body = "Have anyone seen the latest Simon's Cat? The cat gets a little too much love from a cute Maine Coon. Poor guy!" };

            // Reply seed
            Reply rpy01 = new Reply { Date = seedDate, PostID = 1, MemberID = 2, Body = "Have you tried a scisor-type claw trimmer? They cut a bit better than the clippers, and won't crack the claw."};

            pst01.Members.Add(mbr01);
            pst01.Replies.Add(rpy01);
            pst02.Members.Add(mbr02);
            pst03.Members.Add(mbr03);

            context.Posts.Add(pst01);
            context.Posts.Add(pst02);
            context.Posts.Add(pst03);

            base.Seed(context);
        }
    }
}