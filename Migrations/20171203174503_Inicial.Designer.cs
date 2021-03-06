﻿// <auto-generated />
using LivroASPdotNETMVC5.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using System;

namespace LivroASPdotNETMVC5.Migrations
{
    [DbContext(typeof(EFContext))]
    [Migration("20171203174503_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

            modelBuilder.Entity("LivroASPdotNETMVC5.Models.Categoria", b =>
                {
                    b.Property<long>("CategoriaId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.HasKey("CategoriaId");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("LivroASPdotNETMVC5.Models.Fabricante", b =>
                {
                    b.Property<long>("FabricanteId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.HasKey("FabricanteId");

                    b.ToTable("Fabricantes");
                });
#pragma warning restore 612, 618
        }
    }
}
