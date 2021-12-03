using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Login_Registration_Page.Models;
using PPEsOrderingSystem.Models;

namespace Login_Registration_Page.Data
{
    public class ApplicationDbContext: IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options)
            :base(options)
        {

        }
        public DbSet<User> Items { get; set; }

        public DbSet<ClassProducts> Class { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<Details> Details { get; set; }

        public DbSet<PrintMeClass> PrintMeClass { get; set; }

        public DbSet<SupplierInfo> SupplierInfo { get; set; }
    }
}
