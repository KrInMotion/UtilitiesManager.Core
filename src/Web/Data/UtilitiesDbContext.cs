using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Data.Entities;

namespace Web.Data
{
    public class UtilitiesDbContext: IdentityDbContext<AppUser, AppRole, string>
    {
        public UtilitiesDbContext(DbContextOptions<UtilitiesDbContext> options) : base(options) { }

        public DbSet<Provider> Providers { get; set; }
        public DbSet<Kind> Kinds { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Month> Months { get; set; }


    }
}
