using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Project.Areas.quantri.Models.BusinessModel
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext() : base("name=BlogDbContextConnectionString")
        {
            
        }
        
        public DbSet<BlogAdministrator> Administrator { get; set; }
        public DbSet<BlogGrantPermission> GrantPermission { get; set; }
    }
}