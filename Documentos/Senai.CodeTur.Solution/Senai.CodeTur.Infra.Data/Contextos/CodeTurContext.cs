using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace Senai.CodeTur.Infra.Data.Contextos
{
    public class CodeTurContext : DbContext
    {
        public DbSet<UsuarioDominio> Usuarios { get; set; }
        public DbSet<PacoteDominio> Pacotes { get; set;  }

        public CodeTurContext(DbContextOptions<CodeTurContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS3T; Initial Catalog = CodeTurManha; integrated security=true");
            }

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UsuarioDominio>().HasData(
                new UsuarioDominio() {
                        Id = 1,
                        Nome = "Jonatas Masson",
                        Email = "admin@codetur.com"
                        Senha = "Codetur@132",
                        Tipo = "Administrador"
                }
            );

            base.OnModelCreating(modelBuilder);           
        }
    }
}
