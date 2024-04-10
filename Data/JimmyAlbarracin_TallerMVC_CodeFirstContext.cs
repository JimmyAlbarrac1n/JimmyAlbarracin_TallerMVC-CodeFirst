using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JimmyAlbarracin_TallerMVC_CodeFirst.Models;

namespace JimmyAlbarracin_TallerMVC_CodeFirst.Data
{
    public class JimmyAlbarracin_TallerMVC_CodeFirstContext : DbContext
    {
        public JimmyAlbarracin_TallerMVC_CodeFirstContext (DbContextOptions<JimmyAlbarracin_TallerMVC_CodeFirstContext> options)
            : base(options)
        {
        }

        public DbSet<JimmyAlbarracin_TallerMVC_CodeFirst.Models.Burger> Burger { get; set; } = default!;
    }
}
