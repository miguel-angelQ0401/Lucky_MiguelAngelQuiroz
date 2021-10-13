using Lucky_MiguelAngelQuiroz.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lucky_MiguelAngelQuiroz.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Suerte> Lucky_MiguelAngelQuiroz { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
    }
}
