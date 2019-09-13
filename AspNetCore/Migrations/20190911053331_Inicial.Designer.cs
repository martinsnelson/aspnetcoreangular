﻿// <auto-generated />
using System;
using AspNetCore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AspNetCore.Migrations
{
    [DbContext(typeof(AspNetCoreContext))]
    [Migration("20190911053331_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AspNetCore.Entities.Categoria", b =>
                {
                    b.Property<int>("CategoriaID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome")
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30);

                    b.HasKey("CategoriaID");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("AspNetCore.Entities.Fornecedor", b =>
                {
                    b.Property<int>("FornecedorID")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("CNPJ")
                        .HasColumnType("bigint")
                        .HasMaxLength(14);

                    b.Property<string>("Email")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Nome")
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Telefone")
                        .HasColumnType("varchar(14)")
                        .HasMaxLength(14);

                    b.HasKey("FornecedorID");

                    b.ToTable("Fornecedor");
                });

            modelBuilder.Entity("AspNetCore.Entities.Produto", b =>
                {
                    b.Property<int>("ProdutoID")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CategoriaID");

                    b.Property<int>("CdCategoria");

                    b.Property<int>("CdFornecedor");

                    b.Property<DateTime>("DataFabricacao");

                    b.Property<DateTime>("DataValidade");

                    b.Property<string>("Descricao")
                        .HasColumnType("varchar(1024)")
                        .HasMaxLength(1024);

                    b.Property<int?>("FornecedorID");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30);

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal");

                    b.HasKey("ProdutoID");

                    b.HasIndex("CategoriaID");

                    b.HasIndex("FornecedorID");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("AspNetCore.Entities.Usuario", b =>
                {
                    b.Property<int>("UsuarioID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email")
                        .HasColumnType("varchar(60)")
                        .HasMaxLength(60);

                    b.Property<string>("Nome")
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30);

                    b.Property<byte[]>("Salt")
                        .HasColumnType("varbinary(128)")
                        .HasMaxLength(128);

                    b.Property<byte[]>("Senha")
                        .HasColumnType("varbinary(128)")
                        .HasMaxLength(128);

                    b.HasKey("UsuarioID");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("AspNetCore.Entities.Produto", b =>
                {
                    b.HasOne("AspNetCore.Entities.Categoria", "Categoria")
                        .WithMany("Produtos")
                        .HasForeignKey("CategoriaID");

                    b.HasOne("AspNetCore.Entities.Fornecedor", "Fornecedor")
                        .WithMany("Produtos")
                        .HasForeignKey("FornecedorID");
                });
#pragma warning restore 612, 618
        }
    }
}