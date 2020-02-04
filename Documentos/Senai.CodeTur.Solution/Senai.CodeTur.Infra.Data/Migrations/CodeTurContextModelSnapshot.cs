﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Senai.CodeTur.Infra.Data.Contextos;

namespace Senai.CodeTur.Infra.Data.Migrations
{
    [DbContext(typeof(CodeTurContext))]
    partial class CodeTurContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Senai.CodeTur.Dominio.Entidades.PacoteDominio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo")
                        .HasColumnName("Ativo")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DataFim");

                    b.Property<DateTime>("DataInicio");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnName("Descricao")
                        .HasColumnType("TEXT");

                    b.Property<string>("Imagem")
                        .IsRequired()
                        .HasColumnName("Imagem")
                        .HasColumnType("varchar(350)");

                    b.Property<string>("Pais")
                        .IsRequired()
                        .HasColumnName("Pais")
                        .HasColumnType("varchar(60)");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnName("Titulo")
                        .HasColumnType("varchar(250)");

                    b.HasKey("Id");

                    b.ToTable("Pacotes");
                });

            modelBuilder.Entity("Senai.CodeTur.Dominio.Entidades.UsuarioDominio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("Email")
                        .HasColumnType("300");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnName("Nome")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnName("Senha")
                        .HasColumnType("20");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnName("Tipo")
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");

                    b.HasData(
                        new { Id = 1, Email = "admin@codetur.com", Nome = "Jonatas Masson", Senha = "Codetur@132", Tipo = "Administrador" }
                    );
                });
#pragma warning restore 612, 618
        }
    }
}
