﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mipalzoleta.RepositorioEFcore.DataContext;

namespace Miplazoleta.RepositorioEFcore.Migrations
{
    [DbContext(typeof(MiplazoletaDbContext))]
    [Migration("20220429031928_tablaMenu")]
    partial class tablaMenu
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.10");

            modelBuilder.Entity("MenuPlato", b =>
                {
                    b.Property<int>("MenusId")
                        .HasColumnType("int");

                    b.Property<int>("platosId")
                        .HasColumnType("int");

                    b.HasKey("MenusId", "platosId");

                    b.HasIndex("platosId");

                    b.ToTable("MenuPlato");
                });

            modelBuilder.Entity("MiPlazoleta.Entities.POCOs.Menu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasColumnType("longtext");

                    b.Property<string>("Nombre")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Menus");
                });

            modelBuilder.Entity("MiPlazoleta.Entities.POCOs.Plato", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasColumnType("longtext");

                    b.Property<string>("Nombre")
                        .HasColumnType("longtext");

                    b.Property<decimal>("precio")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.ToTable("Platos");
                });

            modelBuilder.Entity("MenuPlato", b =>
                {
                    b.HasOne("MiPlazoleta.Entities.POCOs.Menu", null)
                        .WithMany()
                        .HasForeignKey("MenusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MiPlazoleta.Entities.POCOs.Plato", null)
                        .WithMany()
                        .HasForeignKey("platosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}