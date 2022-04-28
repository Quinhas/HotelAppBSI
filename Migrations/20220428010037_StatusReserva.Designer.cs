﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HotelApp.Migrations
{
    [DbContext(typeof(HotelAppContext))]
    [Migration("20220428010037_StatusReserva")]
    partial class StatusReserva
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("HotelApp.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cpf")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DtNascimento")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Endereco")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<string>("Rg")
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefone")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("HotelApp.Models.Quarto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descricao")
                        .HasColumnType("TEXT");

                    b.Property<string>("Localizacao")
                        .HasColumnType("TEXT");

                    b.Property<int>("Numero")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StatusQuartoID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TipoQuartoID")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("StatusQuartoID");

                    b.HasIndex("TipoQuartoID");

                    b.ToTable("Quarto");
                });

            modelBuilder.Entity("HotelApp.Models.Reserva", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ClienteID")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataCheckIn")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataCheckOut")
                        .HasColumnType("TEXT");

                    b.Property<int>("QuartoID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Status")
                        .HasColumnType("TEXT");

                    b.Property<int?>("StatusReservaID")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ClienteID");

                    b.HasIndex("QuartoID");

                    b.HasIndex("StatusReservaID");

                    b.ToTable("Reserva");
                });

            modelBuilder.Entity("HotelApp.Models.StatusQuarto", b =>
                {
                    b.Property<int>("StatusQuartoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descricao")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.HasKey("StatusQuartoID");

                    b.ToTable("StatusQuarto");
                });

            modelBuilder.Entity("HotelApp.Models.StatusReserva", b =>
                {
                    b.Property<int>("StatusReservaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descricao")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.HasKey("StatusReservaID");

                    b.ToTable("StatusReserva");
                });

            modelBuilder.Entity("HotelApp.Models.TipoQuarto", b =>
                {
                    b.Property<int>("TipoQuartoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descricao")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<double>("Preco")
                        .HasColumnType("REAL");

                    b.HasKey("TipoQuartoID");

                    b.ToTable("TipoQuarto");
                });

            modelBuilder.Entity("HotelApp.Models.Quarto", b =>
                {
                    b.HasOne("HotelApp.Models.StatusQuarto", "StatusQuarto")
                        .WithMany("Quartos")
                        .HasForeignKey("StatusQuartoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HotelApp.Models.TipoQuarto", "TipoQuarto")
                        .WithMany("Quartos")
                        .HasForeignKey("TipoQuartoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("StatusQuarto");

                    b.Navigation("TipoQuarto");
                });

            modelBuilder.Entity("HotelApp.Models.Reserva", b =>
                {
                    b.HasOne("HotelApp.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HotelApp.Models.Quarto", "Quarto")
                        .WithMany()
                        .HasForeignKey("QuartoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HotelApp.Models.StatusReserva", null)
                        .WithMany("Reservas")
                        .HasForeignKey("StatusReservaID");

                    b.Navigation("Cliente");

                    b.Navigation("Quarto");
                });

            modelBuilder.Entity("HotelApp.Models.StatusQuarto", b =>
                {
                    b.Navigation("Quartos");
                });

            modelBuilder.Entity("HotelApp.Models.StatusReserva", b =>
                {
                    b.Navigation("Reservas");
                });

            modelBuilder.Entity("HotelApp.Models.TipoQuarto", b =>
                {
                    b.Navigation("Quartos");
                });
#pragma warning restore 612, 618
        }
    }
}
