
using Domain.Entity;
using Infrastucture.ViewModel;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastucture.Data
{
    public class FreeBookDbContext:IdentityDbContext<ApplicationUser>
    {
        public FreeBookDbContext(DbContextOptions<FreeBookDbContext> options):base(options) 
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Book> Books { get;set; }   
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<LogBook> LogBooks { get; set; }
        public DbSet<LogCategory> LogCategories { get; set; }   
        public DbSet<LogSubCategory> LogSubCategories { get; set; }
    }
}
