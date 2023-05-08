using Chapter_AtividadeSenai_UC14.Models;
using Microsoft.EntityFrameworkCore;

namespace Chapter_AtividadeSenai_UC14.Contexts
{
    public class Sqlcontext : DbContext
    {
        public Sqlcontext() { }

        public Sqlcontext(DbContextOptions<Sqlcontext> options) : base(options) { }

        protected override void

           OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source = DESKTOP-43EVB7H\\SQLEXPRESS; initial catalog = Chapter; Integrated Security = true; TrustServerCertificate=True");
               // optionsBuilder.UseSqlServer("Data Source = DESKTOP-43EVB7H\\SQLEXPRESS; initial catalog = Chapter; Integrated Security = true");
            }
        }
        public DbSet<Livro> Livros { get; set; }
    }
}