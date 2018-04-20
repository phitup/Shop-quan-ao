using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Project.Areas.quantri.Models.BusinessModel
{
    public class BlogDatabaseInitializer :DropCreateDatabaseIfModelChanges<BlogDbContext>
    {
        protected override void Seed(BlogDbContext context)
        {
            var admin = new BlogAdministrator()
            {
                Username = "phitup",
                Password = "123123123"
            };
            context.Administrator.Add(admin);
            var user01 = new BlogAdministrator()
            {
                Username = "user01",
                Password = "123123123"
            };
            context.Administrator.Add(user01);
            context.SaveChanges();
        }
    }
}