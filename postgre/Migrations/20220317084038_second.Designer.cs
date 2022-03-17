﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using postgre.Models;

namespace postgre.Migrations
{
    [DbContext(typeof(BookDbContext))]
    [Migration("20220317084038_second")]
    partial class second
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("DotnetandPostgresql.Models.Author", b =>
                {
                    b.Property<int>("AuthorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("AuthorName")
                        .HasColumnType("text");

                    b.HasKey("AuthorID");

                    b.ToTable("authors");

                    b.HasData(
                        new
                        {
                            AuthorID = 1,
                            AuthorName = "sreehari"
                        },
                        new
                        {
                            AuthorID = 2,
                            AuthorName = "nikhil"
                        },
                        new
                        {
                            AuthorID = 3,
                            AuthorName = "akhil"
                        });
                });

            modelBuilder.Entity("DotnetandPostgresql.Models.Books", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("AuthorFK")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("Price")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("AuthorFK");

                    b.ToTable("books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorFK = 1,
                            Description = "japanese",
                            Name = "Ikigai",
                            Price = 10000
                        },
                        new
                        {
                            Id = 2,
                            AuthorFK = 2,
                            Description = "money",
                            Name = "rich dad poor dad",
                            Price = 50000
                        },
                        new
                        {
                            Id = 3,
                            AuthorFK = 3,
                            Description = "novel",
                            Name = "anxious people",
                            Price = 20000
                        });
                });

            modelBuilder.Entity("DotnetandPostgresql.Models.Books", b =>
                {
                    b.HasOne("DotnetandPostgresql.Models.Author", "Author")
                        .WithMany("Book")
                        .HasForeignKey("AuthorFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
