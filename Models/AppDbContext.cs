using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Usuarios.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Usuario> Usuario { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>()
                .Property(p => p.Nome)
                    .HasMaxLength(80);
            modelBuilder.Entity<Usuario>()
                .Property(p => p.Sobrenome)
                    .HasMaxLength(255);
            modelBuilder.Entity<Usuario>()
                .Property(p => p.Sobrenome)
                    .HasMaxLength(100);
            modelBuilder.Entity<Usuario>()
                .HasData(
                    new Usuario { Id = 1, Nome = "Braian", Sobrenome = "Ferraz ", Email = "braferraz26@gmail.com" },
                    new Usuario { Id = 2, Nome = "Maria", Sobrenome = "Souza ", Email = "souzamaria@gmail.com" },
                    new Usuario { Id = 3, Nome = "João", Sobrenome = "Santos ", Email = "joaosantos@gmail.com" });
        }
    }
}
