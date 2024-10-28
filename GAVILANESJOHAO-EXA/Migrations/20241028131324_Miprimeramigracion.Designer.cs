﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GAVILANESJOHAO_EXA.Migrations
{
    [DbContext(typeof(GAVILANESJOHAO_EXAContext))]
    [Migration("20241028131324_Miprimeramigracion")]
    partial class Miprimeramigracion
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GAVILANESJOHAO_EXAMEN.Models.Celular", b =>
                {
                    b.Property<int>("IdCelular")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCelular"));

                    b.Property<string>("NombreModelo")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("año")
                        .HasColumnType("int");

                    b.Property<float>("precio")
                        .HasMaxLength(55)
                        .HasColumnType("real");

                    b.HasKey("IdCelular");

                    b.ToTable("Celular");
                });

            modelBuilder.Entity("GAVILANESJOHAO_EXAMEN.Models.EGavilanes", b =>
                {
                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdCelular")
                        .HasColumnType("int");

                    b.Property<bool>("NacionalEcuatoriano")
                        .HasColumnType("bit");

                    b.Property<int>("cedula")
                        .HasColumnType("int");

                    b.Property<float>("peso")
                        .HasMaxLength(50)
                        .HasColumnType("real");

                    b.HasKey("Nombre");

                    b.HasIndex("IdCelular");

                    b.ToTable("EGavilanes");
                });

            modelBuilder.Entity("GAVILANESJOHAO_EXAMEN.Models.EGavilanes", b =>
                {
                    b.HasOne("GAVILANESJOHAO_EXAMEN.Models.Celular", "Celular")
                        .WithMany()
                        .HasForeignKey("IdCelular")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Celular");
                });
#pragma warning restore 612, 618
        }
    }
}
