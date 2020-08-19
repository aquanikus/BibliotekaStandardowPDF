using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BibliotekaStandardowPDF.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        { }
        public DbSet<Dokument> Dokument { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            /*modelBuilder.Entity<Dokument>().HasData(
                new Dokument
                {
                    Id_dokumentu = 1,
                    Temat = "PRO-Q-OPL-doukuent1",
                    Tresc = "<h1>test</h1>"
                }
            );*/
        }
    }
}
