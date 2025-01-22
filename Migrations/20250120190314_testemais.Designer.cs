﻿// <auto-generated />
using DatabaseTest.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DatabaseTest.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250120190314_testemais")]
    partial class testemais
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("DatabaseTest.Models.Categoria", b =>
                {
                    b.Property<int>("CategoriaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("CategoriaId"));

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.HasKey("CategoriaId");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("DatabaseTest.Models.ProductSubEntitiesType.ImagesPath", b =>
                {
                    b.Property<int>("ImagesPathId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ImagesPathId"));

                    b.Property<string>("FeaturedImagePath")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("ProdutoId")
                        .HasColumnType("int");

                    b.PrimitiveCollection<string>("SecondaryImagesPath")
                        .HasColumnType("longtext");

                    b.HasKey("ImagesPathId");

                    b.HasIndex("ProdutoId")
                        .IsUnique();

                    b.ToTable("ImagesPath");
                });

            modelBuilder.Entity("DatabaseTest.Models.Produto", b =>
                {
                    b.Property<int>("ProdutoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ProdutoId"));

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.HasKey("ProdutoId");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("DatabaseTest.Models.ProductSubEntitiesType.ImagesPath", b =>
                {
                    b.HasOne("DatabaseTest.Models.Produto", "FK_Produto")
                        .WithOne("ImagesPath")
                        .HasForeignKey("DatabaseTest.Models.ProductSubEntitiesType.ImagesPath", "ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FK_Produto");
                });

            modelBuilder.Entity("DatabaseTest.Models.Produto", b =>
                {
                    b.Navigation("ImagesPath")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
