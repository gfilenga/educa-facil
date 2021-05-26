﻿// <auto-generated />
using System;
using EducaFacil.Infra.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EducaFacil.Infra.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EducaFacil.Domain.Models.Aluno", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConfirmPassword")
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Password")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Telefone")
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime>("Updated_at")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Alunos");
                });

            modelBuilder.Entity("EducaFacil.Domain.Models.AlunoCurso", b =>
                {
                    b.Property<Guid>("AlunoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CursoId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("AlunoId", "CursoId");

                    b.HasIndex("CursoId");

                    b.ToTable("AlunoCursos");
                });

            modelBuilder.Entity("EducaFacil.Domain.Models.Assinatura", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AlunoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataExpiracao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Updated_at")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AlunoId")
                        .IsUnique();

                    b.ToTable("Assinaturas");
                });

            modelBuilder.Entity("EducaFacil.Domain.Models.Aula", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ModuloId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("TimeInMinutes")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime>("Updated_at")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ModuloId");

                    b.ToTable("Aulas");
                });

            modelBuilder.Entity("EducaFacil.Domain.Models.Curso", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("datetime2");

                    b.Property<int>("TimeInMinutes")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime>("Updated_at")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Cursos");
                });

            modelBuilder.Entity("EducaFacil.Domain.Models.Modulo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CursoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("TimeInMinutes")
                        .HasColumnType("int");

                    b.Property<string>("Titulo")
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime>("Updated_at")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CursoId");

                    b.ToTable("Modulos");
                });

            modelBuilder.Entity("EducaFacil.Domain.Models.Pagamento", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AssinaturaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Days")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Updated_at")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Value")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("AssinaturaId");

                    b.ToTable("Pagamentos");
                });

            modelBuilder.Entity("EducaFacil.Domain.Models.AlunoCurso", b =>
                {
                    b.HasOne("EducaFacil.Domain.Models.Aluno", "Aluno")
                        .WithMany("AlunoCursos")
                        .HasForeignKey("AlunoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EducaFacil.Domain.Models.Curso", "Curso")
                        .WithMany("AlunoCursos")
                        .HasForeignKey("CursoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Aluno");

                    b.Navigation("Curso");
                });

            modelBuilder.Entity("EducaFacil.Domain.Models.Assinatura", b =>
                {
                    b.HasOne("EducaFacil.Domain.Models.Aluno", "Aluno")
                        .WithOne("Assinatura")
                        .HasForeignKey("EducaFacil.Domain.Models.Assinatura", "AlunoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Aluno");
                });

            modelBuilder.Entity("EducaFacil.Domain.Models.Aula", b =>
                {
                    b.HasOne("EducaFacil.Domain.Models.Modulo", "Modulo")
                        .WithMany("Aulas")
                        .HasForeignKey("ModuloId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Modulo");
                });

            modelBuilder.Entity("EducaFacil.Domain.Models.Modulo", b =>
                {
                    b.HasOne("EducaFacil.Domain.Models.Curso", "Curso")
                        .WithMany("Modulos")
                        .HasForeignKey("CursoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Curso");
                });

            modelBuilder.Entity("EducaFacil.Domain.Models.Pagamento", b =>
                {
                    b.HasOne("EducaFacil.Domain.Models.Assinatura", "Assinatura")
                        .WithMany("Pagamentos")
                        .HasForeignKey("AssinaturaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Assinatura");
                });

            modelBuilder.Entity("EducaFacil.Domain.Models.Aluno", b =>
                {
                    b.Navigation("AlunoCursos");

                    b.Navigation("Assinatura");
                });

            modelBuilder.Entity("EducaFacil.Domain.Models.Assinatura", b =>
                {
                    b.Navigation("Pagamentos");
                });

            modelBuilder.Entity("EducaFacil.Domain.Models.Curso", b =>
                {
                    b.Navigation("AlunoCursos");

                    b.Navigation("Modulos");
                });

            modelBuilder.Entity("EducaFacil.Domain.Models.Modulo", b =>
                {
                    b.Navigation("Aulas");
                });
#pragma warning restore 612, 618
        }
    }
}
