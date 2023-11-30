﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RecipeBook.API.Models;

#nullable disable

namespace RecipeBook.API.Migrations
{
    [DbContext(typeof(RecipeBookContext))]
    [Migration("20221115162853_RecipesNumber_added")]
    partial class RecipesNumber_added
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CategoryRecipe", b =>
                {
                    b.Property<int>("CategoriesId")
                        .HasColumnType("int");

                    b.Property<int>("RecipesId")
                        .HasColumnType("int");

                    b.HasKey("CategoriesId", "RecipesId");

                    b.HasIndex("RecipesId");

                    b.ToTable("CategoryRecipe");
                });

            modelBuilder.Entity("RecipeBook.API.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("RecipeBook.API.Models.Recipe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CookTime")
                        .HasColumnType("int");

                    b.Property<string>("Ingredients")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Method")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<double>("RatingsAvg")
                        .HasColumnType("float");

                    b.Property<int>("RecipeBookId")
                        .HasColumnType("int");

                    b.Property<int>("Serves")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RecipeBookId");

                    b.ToTable("Recipes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CookTime = 12,
                            Ingredients = "3 Eggs",
                            Method = "Cook",
                            Name = "Apple pie",
                            RatingsAvg = 0.5,
                            RecipeBookId = 1,
                            Serves = 0
                        },
                        new
                        {
                            Id = 2,
                            CookTime = 10,
                            Ingredients = "2 Eggs",
                            Method = "Cook",
                            Name = "Apple pie2",
                            RatingsAvg = 0.5,
                            RecipeBookId = 1,
                            Serves = 0
                        });
                });

            modelBuilder.Entity("RecipeBook.API.Models.RecipeBook", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RecipesNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("RecipeBooks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "...",
                            Name = "My recipe book",
                            RecipesNumber = 2
                        });
                });

            modelBuilder.Entity("CategoryRecipe", b =>
                {
                    b.HasOne("RecipeBook.API.Models.Category", null)
                        .WithMany()
                        .HasForeignKey("CategoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RecipeBook.API.Models.Recipe", null)
                        .WithMany()
                        .HasForeignKey("RecipesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RecipeBook.API.Models.Recipe", b =>
                {
                    b.HasOne("RecipeBook.API.Models.RecipeBook", "RecipeBook")
                        .WithMany("Recipes")
                        .HasForeignKey("RecipeBookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RecipeBook");
                });

            modelBuilder.Entity("RecipeBook.API.Models.RecipeBook", b =>
                {
                    b.Navigation("Recipes");
                });
#pragma warning restore 612, 618
        }
    }
}
