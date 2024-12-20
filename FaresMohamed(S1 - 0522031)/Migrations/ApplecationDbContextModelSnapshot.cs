﻿// <auto-generated />
using System;
using FaresMohamed_S1___0522031_.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FaresMohamed_S1___0522031_.Migrations
{
    [DbContext(typeof(ApplecationDbContext))]
    partial class ApplecationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DirectorModelMovieModel", b =>
                {
                    b.Property<int>("directorModelsDirectorModelId")
                        .HasColumnType("int");

                    b.Property<int>("movieModelsmovieId")
                        .HasColumnType("int");

                    b.HasKey("directorModelsDirectorModelId", "movieModelsmovieId");

                    b.HasIndex("movieModelsmovieId");

                    b.ToTable("DirectorModelMovieModel");
                });

            modelBuilder.Entity("FaresMohamed_S1___0522031_.Models.CategoryModel", b =>
                {
                    b.Property<int>("CategoryModelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryModelId"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryModelId");

                    b.ToTable("categoryModels");
                });

            modelBuilder.Entity("FaresMohamed_S1___0522031_.Models.Cinema", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("placeholder")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("cinemas");
                });

            modelBuilder.Entity("FaresMohamed_S1___0522031_.Models.DirectorModel", b =>
                {
                    b.Property<int>("DirectorModelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DirectorModelId"));

                    b.Property<string>("Contact")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NationalityModelId")
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DirectorModelId");

                    b.HasIndex("NationalityModelId")
                        .IsUnique();

                    b.ToTable("directorModels");
                });

            modelBuilder.Entity("FaresMohamed_S1___0522031_.Models.MovieModel", b =>
                {
                    b.Property<int>("movieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("movieId"));

                    b.Property<int>("CategoryModelzCategoryModelId")
                        .HasColumnType("int");

                    b.Property<int>("CinemaModelId")
                        .HasColumnType("int");

                    b.Property<DateOnly>("ReleaseYear")
                        .HasColumnType("date");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("movieId");

                    b.HasIndex("CategoryModelzCategoryModelId");

                    b.HasIndex("CinemaModelId");

                    b.ToTable("movieModels");
                });

            modelBuilder.Entity("FaresMohamed_S1___0522031_.Models.NationalityModel", b =>
                {
                    b.Property<int>("NationalityModelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NationalityModelId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NationalityModelId");

                    b.ToTable("nationalityModels");
                });

            modelBuilder.Entity("DirectorModelMovieModel", b =>
                {
                    b.HasOne("FaresMohamed_S1___0522031_.Models.DirectorModel", null)
                        .WithMany()
                        .HasForeignKey("directorModelsDirectorModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FaresMohamed_S1___0522031_.Models.MovieModel", null)
                        .WithMany()
                        .HasForeignKey("movieModelsmovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FaresMohamed_S1___0522031_.Models.DirectorModel", b =>
                {
                    b.HasOne("FaresMohamed_S1___0522031_.Models.NationalityModel", "nationalityModels")
                        .WithOne("DirectorModel")
                        .HasForeignKey("FaresMohamed_S1___0522031_.Models.DirectorModel", "NationalityModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("nationalityModels");
                });

            modelBuilder.Entity("FaresMohamed_S1___0522031_.Models.MovieModel", b =>
                {
                    b.HasOne("FaresMohamed_S1___0522031_.Models.CategoryModel", "CategoryModelz")
                        .WithMany("movieModels")
                        .HasForeignKey("CategoryModelzCategoryModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FaresMohamed_S1___0522031_.Models.Cinema", "CinemaModel")
                        .WithMany("Models")
                        .HasForeignKey("CinemaModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CategoryModelz");

                    b.Navigation("CinemaModel");
                });

            modelBuilder.Entity("FaresMohamed_S1___0522031_.Models.CategoryModel", b =>
                {
                    b.Navigation("movieModels");
                });

            modelBuilder.Entity("FaresMohamed_S1___0522031_.Models.Cinema", b =>
                {
                    b.Navigation("Models");
                });

            modelBuilder.Entity("FaresMohamed_S1___0522031_.Models.NationalityModel", b =>
                {
                    b.Navigation("DirectorModel")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
