﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SuperMyCadoApi.Models;

#nullable disable

namespace SuperMyCadoApi.Migrations
{
    [DbContext(typeof(SuperMyCadoContext))]
    partial class SuperMyCadoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.12");

            modelBuilder.Entity("SuperMyCadoApi.Models.Funcionario", b =>
                {
                    b.Property<long>("FuncionarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long?>("LojaFuncionarioLojaId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("NifFuncionario")
                        .HasColumnType("TEXT");

                    b.Property<string>("NomeFuncionario")
                        .HasColumnType("TEXT");

                    b.HasKey("FuncionarioId");

                    b.HasIndex("LojaFuncionarioLojaId");

                    b.ToTable("Funcionarios");
                });

            modelBuilder.Entity("SuperMyCadoApi.Models.Gama", b =>
                {
                    b.Property<long>("GamaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("NomeGama")
                        .HasColumnType("TEXT");

                    b.Property<string>("SiglaGama")
                        .HasColumnType("TEXT");

                    b.HasKey("GamaId");

                    b.ToTable("GamaDeProdutos");
                });

            modelBuilder.Entity("SuperMyCadoApi.Models.Loja", b =>
                {
                    b.Property<long>("LojaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("LocalizacaoLoja")
                        .HasColumnType("TEXT");

                    b.Property<string>("NomeLoja")
                        .HasColumnType("TEXT");

                    b.HasKey("LojaId");

                    b.ToTable("Lojas");
                });

            modelBuilder.Entity("SuperMyCadoApi.Models.Produto", b =>
                {
                    b.Property<long>("ProdutoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CodigoProduto")
                        .HasColumnType("TEXT");

                    b.Property<long?>("NomeLojaProdutoLojaId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("NomeProduto")
                        .HasColumnType("TEXT");

                    b.Property<long?>("SiglaGamaProdutoGamaId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ProdutoId");

                    b.HasIndex("NomeLojaProdutoLojaId");

                    b.HasIndex("SiglaGamaProdutoGamaId");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("SuperMyCadoApi.Models.Funcionario", b =>
                {
                    b.HasOne("SuperMyCadoApi.Models.Loja", "LojaFuncionario")
                        .WithMany()
                        .HasForeignKey("LojaFuncionarioLojaId");

                    b.Navigation("LojaFuncionario");
                });

            modelBuilder.Entity("SuperMyCadoApi.Models.Produto", b =>
                {
                    b.HasOne("SuperMyCadoApi.Models.Loja", "NomeLojaProduto")
                        .WithMany()
                        .HasForeignKey("NomeLojaProdutoLojaId");

                    b.HasOne("SuperMyCadoApi.Models.Gama", "SiglaGamaProduto")
                        .WithMany()
                        .HasForeignKey("SiglaGamaProdutoGamaId");

                    b.Navigation("NomeLojaProduto");

                    b.Navigation("SiglaGamaProduto");
                });
#pragma warning restore 612, 618
        }
    }
}
