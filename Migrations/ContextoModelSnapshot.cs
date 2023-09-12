﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WMVCBCCT12023.Models;

#nullable disable

namespace WMVCBCCT12023.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WMVCBCCT12023.Models.Aluno", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<DateTime>("aniversario")
                        .HasColumnType("datetime2");

                    b.Property<int>("cursoID")
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<int>("periodo")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("cursoID");

                    b.ToTable("Alunos");
                });

            modelBuilder.Entity("WMVCBCCT12023.Models.Atendimento", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("alunoID")
                        .HasColumnType("int");

                    b.Property<DateTime>("data")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("hora")
                        .HasColumnType("datetime2");

                    b.Property<int>("salaID")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("alunoID");

                    b.HasIndex("salaID");

                    b.ToTable("Atendimentos");
                });

            modelBuilder.Entity("WMVCBCCT12023.Models.Curso", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("descricao")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.HasKey("id");

                    b.ToTable("Cursos");
                });

            modelBuilder.Entity("WMVCBCCT12023.Models.Sala", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("descricao")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("quantidade")
                        .HasColumnType("int");

                    b.Property<int>("situacao")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Sala");
                });

            modelBuilder.Entity("WMVCBCCT12023.Models.Aluno", b =>
                {
                    b.HasOne("WMVCBCCT12023.Models.Curso", "curso")
                        .WithMany()
                        .HasForeignKey("cursoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("curso");
                });

            modelBuilder.Entity("WMVCBCCT12023.Models.Atendimento", b =>
                {
                    b.HasOne("WMVCBCCT12023.Models.Aluno", "aluno")
                        .WithMany()
                        .HasForeignKey("alunoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WMVCBCCT12023.Models.Sala", "sala")
                        .WithMany()
                        .HasForeignKey("salaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("aluno");

                    b.Navigation("sala");
                });
#pragma warning restore 612, 618
        }
    }
}
