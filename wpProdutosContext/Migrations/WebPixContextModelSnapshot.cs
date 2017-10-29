﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Repository;
using System;

namespace Repository.Migrations
{
    [DbContext(typeof(WebPixContext))]
    partial class WebPixContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entity.Preco", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Ativo");

                    b.Property<DateTime>("DataFinal");

                    b.Property<DateTime>("DataInicio");

                    b.Property<string>("Descricao");

                    b.Property<string>("Nome");

                    b.Property<int>("PrecoPromocional");

                    b.Property<int>("PrecoReal");

                    b.Property<int>("Status");

                    b.Property<int>("UsuarioCriacao");

                    b.Property<int>("UsuarioEdicao");

                    b.Property<DateTime>("dataCriacao");

                    b.Property<DateTime>("dataEdicao");

                    b.Property<int>("idCliente");

                    b.HasKey("ID");

                    b.ToTable("Preco");
                });

            modelBuilder.Entity("Entity.Produto", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Altura");

                    b.Property<bool>("Ativo");

                    b.Property<int>("Catalogo");

                    b.Property<string>("CodExterno");

                    b.Property<int>("Comprimento");

                    b.Property<string>("Descricao");

                    b.Property<string>("DescricaoLonga");

                    b.Property<string>("Estoque");

                    b.Property<int>("EstoqueMinimo");

                    b.Property<string>("Fabrinte");

                    b.Property<int>("Largura");

                    b.Property<string>("Nome");

                    b.Property<int>("Peso");

                    b.Property<int?>("PrecoID");

                    b.Property<int>("Status");

                    b.Property<int>("UsuarioCriacao");

                    b.Property<int>("UsuarioEdicao");

                    b.Property<DateTime>("dataCriacao");

                    b.Property<DateTime>("dataEdicao");

                    b.Property<int>("idCliente");

                    b.HasKey("ID");

                    b.HasIndex("PrecoID");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("Entity.ProdutoSku", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Ativo");

                    b.Property<string>("CodSkuExterno");

                    b.Property<string>("Descricao");

                    b.Property<int>("IDSku");

                    b.Property<string>("Nome");

                    b.Property<int?>("ProdutoID");

                    b.Property<int>("SkuEstoque");

                    b.Property<int>("SkuPeso");

                    b.Property<int>("Status");

                    b.Property<int>("UsuarioCriacao");

                    b.Property<int>("UsuarioEdicao");

                    b.Property<DateTime>("dataCriacao");

                    b.Property<DateTime>("dataEdicao");

                    b.Property<int>("idCliente");

                    b.HasKey("ID");

                    b.HasIndex("ProdutoID");

                    b.ToTable("ProdutoSku");
                });

            modelBuilder.Entity("Entity.Propiedades", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Ativo");

                    b.Property<string>("Descricao");

                    b.Property<string>("Nome");

                    b.Property<int?>("ProdutoSkuID");

                    b.Property<int>("Status");

                    b.Property<int>("UsuarioCriacao");

                    b.Property<int>("UsuarioEdicao");

                    b.Property<DateTime>("dataCriacao");

                    b.Property<DateTime>("dataEdicao");

                    b.Property<int>("idCliente");

                    b.HasKey("ID");

                    b.HasIndex("ProdutoSkuID");

                    b.ToTable("Propiedades");
                });

            modelBuilder.Entity("Entity.Produto", b =>
                {
                    b.HasOne("Entity.Preco", "Preco")
                        .WithMany()
                        .HasForeignKey("PrecoID");
                });

            modelBuilder.Entity("Entity.ProdutoSku", b =>
                {
                    b.HasOne("Entity.Produto")
                        .WithMany("Sku")
                        .HasForeignKey("ProdutoID");
                });

            modelBuilder.Entity("Entity.Propiedades", b =>
                {
                    b.HasOne("Entity.ProdutoSku")
                        .WithMany("Propiedade")
                        .HasForeignKey("ProdutoSkuID");
                });
#pragma warning restore 612, 618
        }
    }
}
