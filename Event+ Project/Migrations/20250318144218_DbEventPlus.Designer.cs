﻿// <auto-generated />
using System;
using Event__Project.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Event__Project.Migrations
{
    [DbContext(typeof(EventContext))]
    [Migration("20250318144218_DbEventPlus")]
    partial class DbEventPlus
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Event__Project.Domains.ComentarioEvento", b =>
                {
                    b.Property<Guid>("IdComentarioEvento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("VARCHAR(200)");

                    b.Property<bool>("Exibe")
                        .HasColumnType("BIT");

                    b.Property<Guid>("IdEvento")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdUsuario")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IdComentarioEvento");

                    b.HasIndex("IdEvento");

                    b.HasIndex("IdUsuario");

                    b.ToTable("ComentarioEvento");
                });

            modelBuilder.Entity("Event__Project.Domains.Evento", b =>
                {
                    b.Property<Guid>("IdEvento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataEvento")
                        .HasColumnType("DATE");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("IdInstituicao")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdTipoEvento")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("NomeEvento")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.HasKey("IdEvento");

                    b.HasIndex("IdInstituicao");

                    b.HasIndex("IdTipoEvento");

                    b.ToTable("Evento");
                });

            modelBuilder.Entity("Event__Project.Domains.Institucoes", b =>
                {
                    b.Property<Guid>("IdInstituicao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CNPJ")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("VARCHAR(30)");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("VARCHAR(60)");

                    b.Property<string>("NomeFantasia")
                        .IsRequired()
                        .HasColumnType("VARCHAR(30)");

                    b.HasKey("IdInstituicao");

                    b.HasIndex("CNPJ")
                        .IsUnique();

                    b.ToTable("Instituicoes");
                });

            modelBuilder.Entity("Event__Project.Domains.PresencaEventos", b =>
                {
                    b.Property<Guid>("IdPresencaEvento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdEvento")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdUsuario")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Situacao")
                        .HasColumnType("BIT");

                    b.HasKey("IdPresencaEvento");

                    b.HasIndex("IdEvento")
                        .IsUnique();

                    b.HasIndex("IdUsuario");

                    b.ToTable("PresencaEventos");
                });

            modelBuilder.Entity("Event__Project.Domains.TipoEventos", b =>
                {
                    b.Property<Guid>("IdTipoEvento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TituloEvento")
                        .IsRequired()
                        .HasColumnType("VARCHAR(60)");

                    b.HasKey("IdTipoEvento");

                    b.ToTable("TipoEvento");
                });

            modelBuilder.Entity("Event__Project.Domains.TiposUsuario", b =>
                {
                    b.Property<Guid>("TipoUsuarioID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TituloTipoUsuario")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.HasKey("TipoUsuarioID");

                    b.ToTable("TiposUsuario");
                });

            modelBuilder.Entity("Event__Project.Domains.Usuarios", b =>
                {
                    b.Property<Guid>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.Property<Guid>("IdTipoUsuario")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("VARCHAR(60)");

                    b.HasKey("IdUsuario");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("IdTipoUsuario");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Event__Project.Domains.ComentarioEvento", b =>
                {
                    b.HasOne("Event__Project.Domains.Evento", "Evento")
                        .WithMany()
                        .HasForeignKey("IdEvento")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Event__Project.Domains.Usuarios", "Usuario")
                        .WithMany()
                        .HasForeignKey("IdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Evento");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Event__Project.Domains.Evento", b =>
                {
                    b.HasOne("Event__Project.Domains.Institucoes", "Instituicao")
                        .WithMany()
                        .HasForeignKey("IdInstituicao")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Event__Project.Domains.TipoEventos", "TiposEvento")
                        .WithMany()
                        .HasForeignKey("IdTipoEvento")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Instituicao");

                    b.Navigation("TiposEvento");
                });

            modelBuilder.Entity("Event__Project.Domains.PresencaEventos", b =>
                {
                    b.HasOne("Event__Project.Domains.Evento", "Evento")
                        .WithOne("PresencaEventos")
                        .HasForeignKey("Event__Project.Domains.PresencaEventos", "IdEvento")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Event__Project.Domains.Usuarios", "Usuarios")
                        .WithMany()
                        .HasForeignKey("IdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Evento");

                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("Event__Project.Domains.Usuarios", b =>
                {
                    b.HasOne("Event__Project.Domains.TiposUsuario", "TipoUsuario")
                        .WithMany()
                        .HasForeignKey("IdTipoUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TipoUsuario");
                });

            modelBuilder.Entity("Event__Project.Domains.Evento", b =>
                {
                    b.Navigation("PresencaEventos");
                });
#pragma warning restore 612, 618
        }
    }
}
