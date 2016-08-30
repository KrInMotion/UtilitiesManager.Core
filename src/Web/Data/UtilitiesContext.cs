using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Data.Entities;

namespace Web.Data
{
    public class UtilitiesDbContext:IdentityDbContext<AppUser>
    {
        public UtilitiesDbContext(DbContextOptions<UtilitiesDbContext> options) : base(options) { }

    }
}
