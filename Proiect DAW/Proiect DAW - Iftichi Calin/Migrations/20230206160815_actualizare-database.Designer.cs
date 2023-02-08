﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Proiect_DAW___Iftichi_Calin.Data;

#nullable disable

namespace ProiectDAWIftichiCalin.Migrations
{
    [DbContext(typeof(ProiectContext))]
    [Migration("20230206160815_actualizare-database")]
    partial class actualizaredatabase
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Proiect_DAW___Iftichi_Calin.Models.Aplicatie", b =>
                {
                    b.Property<Guid>("UtilizatorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("JobId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataModified")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2");

                    b.HasKey("UtilizatorId", "JobId");

                    b.HasIndex("JobId");

                    b.ToTable("Aplicatie");
                });

            modelBuilder.Entity("Proiect_DAW___Iftichi_Calin.Models.Companie", b =>
                {
                    b.Property<Guid>("CompanieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataModified")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2");

                    b.Property<string>("Descriere_companie")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nume_companie")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ParolaHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Roluri")
                        .HasColumnType("int");

                    b.Property<Guid>("SediuId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CompanieId");

                    b.HasIndex("SediuId")
                        .IsUnique();

                    b.ToTable("Companii");
                });

            modelBuilder.Entity("Proiect_DAW___Iftichi_Calin.Models.Job", b =>
                {
                    b.Property<Guid>("JobId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Categorie_job")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("CompanieId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Criterii")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataModified")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2");

                    b.Property<string>("Descriere_job")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nume_Job")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("JobId");

                    b.HasIndex("CompanieId");

                    b.ToTable("Joburi");
                });

            modelBuilder.Entity("Proiect_DAW___Iftichi_Calin.Models.Sediu", b =>
                {
                    b.Property<Guid>("SediuId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Adresa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataModified")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2");

                    b.Property<string>("Oras")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SediuId");

                    b.ToTable("Sedii");
                });

            modelBuilder.Entity("Proiect_DAW___Iftichi_Calin.Models.Utilizator", b =>
                {
                    b.Property<Guid>("UtilizatorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataModified")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Roluri")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UtilizatorId");

                    b.ToTable("Utilizatori");
                });

            modelBuilder.Entity("Proiect_DAW___Iftichi_Calin.Models.Aplicatie", b =>
                {
                    b.HasOne("Proiect_DAW___Iftichi_Calin.Models.Job", "Job")
                        .WithMany("Aplicatie")
                        .HasForeignKey("JobId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Proiect_DAW___Iftichi_Calin.Models.Utilizator", "Utilizator")
                        .WithMany("Aplicatie")
                        .HasForeignKey("UtilizatorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Job");

                    b.Navigation("Utilizator");
                });

            modelBuilder.Entity("Proiect_DAW___Iftichi_Calin.Models.Companie", b =>
                {
                    b.HasOne("Proiect_DAW___Iftichi_Calin.Models.Sediu", "Sediu")
                        .WithOne("Companie")
                        .HasForeignKey("Proiect_DAW___Iftichi_Calin.Models.Companie", "SediuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sediu");
                });

            modelBuilder.Entity("Proiect_DAW___Iftichi_Calin.Models.Job", b =>
                {
                    b.HasOne("Proiect_DAW___Iftichi_Calin.Models.Companie", "Companie")
                        .WithMany("Joburi")
                        .HasForeignKey("CompanieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Companie");
                });

            modelBuilder.Entity("Proiect_DAW___Iftichi_Calin.Models.Companie", b =>
                {
                    b.Navigation("Joburi");
                });

            modelBuilder.Entity("Proiect_DAW___Iftichi_Calin.Models.Job", b =>
                {
                    b.Navigation("Aplicatie");
                });

            modelBuilder.Entity("Proiect_DAW___Iftichi_Calin.Models.Sediu", b =>
                {
                    b.Navigation("Companie")
                        .IsRequired();
                });

            modelBuilder.Entity("Proiect_DAW___Iftichi_Calin.Models.Utilizator", b =>
                {
                    b.Navigation("Aplicatie");
                });
#pragma warning restore 612, 618
        }
    }
}
