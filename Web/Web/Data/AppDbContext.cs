using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Models;

namespace Web.Data
{
    public class AppDbContext:DbContext
    {

        public AppDbContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<Setting> Settings { get; set; }
        public DbSet<Portofilo> Portofilos { get; set; }
        public DbSet<Message> Messages { get; set; }

    }
}
