﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mipalzoleta.RepositorioEFcore.DataContext;

namespace Miplazoleta.RepositorioEFcore.Migrations
{
    [DbContext(typeof(MiplazoletaDbContext))]
    [Migration("20220628004232_ChangeApiFluid")]
    partial class ChangeApiFluid
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.10");

            modelBuilder.Entity("MiPlazoleta.Entities.POCOs.Menu", b =>
                {
                    b.Property<int>("IdMenu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasColumnType("longtext");

                    b.Property<string>("Nombre")
                        .HasColumnType("longtext");

                    b.HasKey("IdMenu");

                    b.ToTable("Menus");
                });

            modelBuilder.Entity("MiPlazoleta.Entities.POCOs.Plato", b =>
                {
                    b.Property<int>("IdPlato")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasColumnType("longtext");

                    b.Property<string>("Nombre")
                        .HasColumnType("longtext");

                    b.Property<decimal>("precio")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("IdPlato");

                    b.ToTable("Platos");
                });

            modelBuilder.Entity("MiPlazoleta.Entities.POCOs.PlatoMenu", b =>
                {
                    b.Property<int>("MenuId")
                        .HasColumnType("int");

                    b.Property<int>("PlatoId")
                        .HasColumnType("int");

                    b.HasKey("MenuId", "PlatoId");

                    b.HasIndex("PlatoId");

                    b.ToTable("PlatoMenu");
                });

            modelBuilder.Entity("MiPlazoleta.Entities.POCOs.PlatoMenu", b =>
                {
                    b.HasOne("MiPlazoleta.Entities.POCOs.Menu", "Menu")
                        .WithMany("PlatoMenu")
                        .HasForeignKey("MenuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MiPlazoleta.Entities.POCOs.Plato", "Plato")
                        .WithMany("PlatoMenu")
                        .HasForeignKey("PlatoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Menu");

                    b.Navigation("Plato");
                });

            modelBuilder.Entity("MiPlazoleta.Entities.POCOs.Menu", b =>
                {
                    b.Navigation("PlatoMenu");
                });

            modelBuilder.Entity("MiPlazoleta.Entities.POCOs.Plato", b =>
                {
                    b.Navigation("PlatoMenu");
                });
#pragma warning restore 612, 618
        }
    }
}
