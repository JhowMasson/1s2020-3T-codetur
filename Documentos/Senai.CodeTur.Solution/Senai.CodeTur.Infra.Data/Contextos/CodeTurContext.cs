using Microsoft.EntityFrameworkCore;
using Senai.CodeTur.Dominio.Entidades;
using System;

namespace Senai.CodeTur.Infra.Data.Contextos
{
    public class CodeTurContext : DbContext
    {
        public DbSet<UsuarioDominio> Usuarios { get; set; }
        public DbSet<PacoteDominio> Pacotes { get; set;  }
        public CodeTurContext()
        {
                
        }

        public CodeTurContext(DbContextOptions<CodeTurContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS3T;Initial Catalog=M_CodeTur;User Id=sa;Password=sa132;integrated security=true");
            }

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UsuarioDominio>().HasData(
                new UsuarioDominio() {
                        Id = 1,
                        Nome = "Jonatas Masson",
                        Email = "admin@codetur.com",
                        Senha = "Codetur@132",
                        Tipo = "Administrador"
                }
            );

            base.OnModelCreating(modelBuilder);           
        }
    }
}
