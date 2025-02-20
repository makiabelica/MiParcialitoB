﻿// <auto-generated />
using MiParcialitoB.CodeFirstModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MiParcialitoB.Migrations
{
    [DbContext(typeof(EFCoreDbContext))]
    partial class EFCoreDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("MiParcialitoB.CodeFirstModel.Curso", b =>
                {
                    b.Property<int>("CursoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("CursoID"));

                    b.Property<string>("NombreCurso")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("CursoID");

                    b.ToTable("Cursos");
                });

            modelBuilder.Entity("MiParcialitoB.CodeFirstModel.Estudiante", b =>
                {
                    b.Property<int>("EstudianteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("EstudianteId"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("EstudianteId");

                    b.ToTable("Estudiantes");
                });

            modelBuilder.Entity("MiParcialitoB.CodeFirstModel.Inscripcion", b =>
                {
                    b.Property<int>("EstudianteID")
                        .HasColumnType("int");

                    b.Property<int>("CursoID")
                        .HasColumnType("int");

                    b.HasKey("EstudianteID", "CursoID");

                    b.HasIndex("CursoID");

                    b.ToTable("Inscripciones");
                });

            modelBuilder.Entity("MiParcialitoB.CodeFirstModel.Inscripcion", b =>
                {
                    b.HasOne("MiParcialitoB.CodeFirstModel.Curso", "Curso")
                        .WithMany("Inscripciones")
                        .HasForeignKey("CursoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MiParcialitoB.CodeFirstModel.Estudiante", "Estudiante")
                        .WithMany("Inscripciones")
                        .HasForeignKey("EstudianteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Curso");

                    b.Navigation("Estudiante");
                });

            modelBuilder.Entity("MiParcialitoB.CodeFirstModel.Curso", b =>
                {
                    b.Navigation("Inscripciones");
                });

            modelBuilder.Entity("MiParcialitoB.CodeFirstModel.Estudiante", b =>
                {
                    b.Navigation("Inscripciones");
                });
#pragma warning restore 612, 618
        }
    }
}
