﻿// <auto-generated />
using System;
using Freelancer.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Freelancer.Migrations
{
    [DbContext(typeof(MvcFreelancerContext))]
    [Migration("20210115105321_updateVirtualClientOnMission")]
    partial class updateVirtualClientOnMission
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("Freelancer.Models.CategorieClient", b =>
                {
                    b.Property<int>("CategorieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("categorie_id")
                        .UseIdentityColumn();

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CategorieId");

                    b.ToTable("CategoriesClient");
                });

            modelBuilder.Entity("Freelancer.Models.Client", b =>
                {
                    b.Property<int>("ClientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("client_id")
                        .UseIdentityColumn();

                    b.Property<int>("CategorieClientId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Nom")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ClientId");

                    b.HasIndex("CategorieClientId");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("Freelancer.Models.Devis", b =>
                {
                    b.Property<int>("DevisId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("devis_id")
                        .UseIdentityColumn();

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DevisDateFinale")
                        .HasColumnType("datetime2");

                    b.Property<string>("Etat")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("MissionId")
                        .HasColumnType("int");

                    b.Property<int>("Montant")
                        .HasColumnType("int");

                    b.Property<int>("MontantFinal")
                        .HasColumnType("int");

                    b.HasKey("DevisId");

                    b.ToTable("Devis");
                });

            modelBuilder.Entity("Freelancer.Models.Mission", b =>
                {
                    b.Property<int>("MissionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("mission_id")
                        .UseIdentityColumn();

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<string>("Debut")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Etat")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Fin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("MissionId");

                    b.HasIndex("ClientId");

                    b.ToTable("Missions");
                });

            modelBuilder.Entity("Freelancer.Models.Client", b =>
                {
                    b.HasOne("Freelancer.Models.CategorieClient", "Categorie")
                        .WithMany()
                        .HasForeignKey("CategorieClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categorie");
                });

            modelBuilder.Entity("Freelancer.Models.Mission", b =>
                {
                    b.HasOne("Freelancer.Models.Client", "client")
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("client");
                });
#pragma warning restore 612, 618
        }
    }
}
