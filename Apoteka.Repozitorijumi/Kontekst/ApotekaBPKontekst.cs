using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apoteka.Modeli;
using Microsoft.EntityFrameworkCore;

namespace Apoteka.Repozitorijumi.Kontekst
{
    public class ApotekaBPKontekst : DbContext
    {
        public ApotekaBPKontekst() { }

        public ApotekaBPKontekst(DbContextOptions<ApotekaBPKontekst> options) : base(options) { }

        public DbSet<Lek> Lek => Set<Lek>();

        protected override void OnModelCreating(ModelBuilder modelBuilder) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-4FJDL95\\SQLEXPRESS;Initial Catalog=ApotekaBP;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

    }
}