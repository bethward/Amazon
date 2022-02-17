﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission7.Models;

namespace Mission7.Migrations
{
    [DbContext(typeof(AmazonBookContext))]
    partial class AmazonBookContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("Mission7.Models.Book", b =>
                {
                    b.Property<int>("BookId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Classification")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("PageCount")
                        .HasColumnType("INTEGER");

                    b.Property<float>("Price")
                        .HasColumnType("REAL");

                    b.Property<string>("Publisher")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("BookId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            BookId = 1,
                            Author = "Victor Hugo",
                            Category = "Classic",
                            Classification = "Fiction",
                            ISBN = "978-0451419439",
                            PageCount = 1488,
                            Price = 9.95f,
                            Publisher = "Signet",
                            Title = "Les Miserables"
                        },
                        new
                        {
                            BookId = 2,
                            Author = "Victor Hugo",
                            Category = "Classic",
                            Classification = "Fiction",
                            ISBN = "978-0451419439",
                            PageCount = 1488,
                            Price = 9.95f,
                            Publisher = "Signet",
                            Title = "Les Miserables"
                        },
                        new
                        {
                            BookId = 3,
                            Author = "Victor Hugo",
                            Category = "Classic",
                            Classification = "Fiction",
                            ISBN = "978-0451419439",
                            PageCount = 1488,
                            Price = 9.95f,
                            Publisher = "Signet",
                            Title = "Les Miserables"
                        },
                        new
                        {
                            BookId = 4,
                            Author = "Victor Hugo",
                            Category = "Classic",
                            Classification = "Fiction",
                            ISBN = "978-0451419439",
                            PageCount = 1488,
                            Price = 9.95f,
                            Publisher = "Signet",
                            Title = "Les Miserables"
                        },
                        new
                        {
                            BookId = 5,
                            Author = "Victor Hugo",
                            Category = "Classic",
                            Classification = "Fiction",
                            ISBN = "978-0451419439",
                            PageCount = 1488,
                            Price = 9.95f,
                            Publisher = "Signet",
                            Title = "Les Miserables"
                        },
                        new
                        {
                            BookId = 6,
                            Author = "Victor Hugo",
                            Category = "Classic",
                            Classification = "Fiction",
                            ISBN = "978-0451419439",
                            PageCount = 1488,
                            Price = 9.95f,
                            Publisher = "Signet",
                            Title = "Les Miserables"
                        },
                        new
                        {
                            BookId = 7,
                            Author = "Victor Hugo",
                            Category = "Classic",
                            Classification = "Fiction",
                            ISBN = "978-0451419439",
                            PageCount = 1488,
                            Price = 9.95f,
                            Publisher = "Signet",
                            Title = "Les Miserables"
                        },
                        new
                        {
                            BookId = 8,
                            Author = "Victor Hugo",
                            Category = "Classic",
                            Classification = "Fiction",
                            ISBN = "978-0451419439",
                            PageCount = 1488,
                            Price = 9.95f,
                            Publisher = "Signet",
                            Title = "Les Miserables"
                        },
                        new
                        {
                            BookId = 9,
                            Author = "Victor Hugo",
                            Category = "Classic",
                            Classification = "Fiction",
                            ISBN = "978-0451419439",
                            PageCount = 1488,
                            Price = 9.95f,
                            Publisher = "Signet",
                            Title = "Les Miserables"
                        },
                        new
                        {
                            BookId = 10,
                            Author = "Victor Hugo",
                            Category = "Classic",
                            Classification = "Fiction",
                            ISBN = "978-0451419439",
                            PageCount = 1488,
                            Price = 9.95f,
                            Publisher = "Signet",
                            Title = "Les Miserables"
                        },
                        new
                        {
                            BookId = 11,
                            Author = "Victor Hugo",
                            Category = "Classic",
                            Classification = "Fiction",
                            ISBN = "978-0451419439",
                            PageCount = 1488,
                            Price = 9.95f,
                            Publisher = "Signet",
                            Title = "Les Miserables"
                        },
                        new
                        {
                            BookId = 12,
                            Author = "Victor Hugo",
                            Category = "Classic",
                            Classification = "Fiction",
                            ISBN = "978-0451419439",
                            PageCount = 1488,
                            Price = 9.95f,
                            Publisher = "Signet",
                            Title = "Les Miserables"
                        },
                        new
                        {
                            BookId = 13,
                            Author = "Victor Hugo",
                            Category = "Classic",
                            Classification = "Fiction",
                            ISBN = "978-0451419439",
                            PageCount = 1488,
                            Price = 9.95f,
                            Publisher = "Signet",
                            Title = "Les Miserables"
                        },
                        new
                        {
                            BookId = 14,
                            Author = "Victor Hugo",
                            Category = "Classic",
                            Classification = "Fiction",
                            ISBN = "978-0451419439",
                            PageCount = 1488,
                            Price = 9.95f,
                            Publisher = "Signet",
                            Title = "Les Miserables"
                        },
                        new
                        {
                            BookId = 15,
                            Author = "Victor Hugo",
                            Category = "Classic",
                            Classification = "Fiction",
                            ISBN = "978-0451419439",
                            PageCount = 1488,
                            Price = 9.95f,
                            Publisher = "Signet",
                            Title = "Les Miserables"
                        },
                        new
                        {
                            BookId = 16,
                            Author = "Victor Hugo",
                            Category = "Classic",
                            Classification = "Fiction",
                            ISBN = "978-0451419439",
                            PageCount = 1488,
                            Price = 9.95f,
                            Publisher = "Signet",
                            Title = "Les Miserables"
                        },
                        new
                        {
                            BookId = 17,
                            Author = "Victor Hugo",
                            Category = "Classic",
                            Classification = "Fiction",
                            ISBN = "978-0451419439",
                            PageCount = 1488,
                            Price = 9.95f,
                            Publisher = "Signet",
                            Title = "Les Miserables"
                        },
                        new
                        {
                            BookId = 18,
                            Author = "Victor Hugo",
                            Category = "Classic",
                            Classification = "Fiction",
                            ISBN = "978-0451419439",
                            PageCount = 1488,
                            Price = 9.95f,
                            Publisher = "Signet",
                            Title = "Les Miserables"
                        },
                        new
                        {
                            BookId = 19,
                            Author = "Victor Hugo",
                            Category = "Classic",
                            Classification = "Fiction",
                            ISBN = "978-0451419439",
                            PageCount = 1488,
                            Price = 9.95f,
                            Publisher = "Signet",
                            Title = "Les Miserables"
                        },
                        new
                        {
                            BookId = 20,
                            Author = "Victor Hugo",
                            Category = "Classic",
                            Classification = "Fiction",
                            ISBN = "978-0451419439",
                            PageCount = 1488,
                            Price = 9.95f,
                            Publisher = "Signet",
                            Title = "Les Miserables"
                        },
                        new
                        {
                            BookId = 21,
                            Author = "Victor Hugo",
                            Category = "Classic",
                            Classification = "Fiction",
                            ISBN = "978-0451419439",
                            PageCount = 1488,
                            Price = 9.95f,
                            Publisher = "Signet",
                            Title = "Les Miserables"
                        },
                        new
                        {
                            BookId = 22,
                            Author = "Victor Hugo",
                            Category = "Classic",
                            Classification = "Fiction",
                            ISBN = "978-0451419439",
                            PageCount = 1488,
                            Price = 9.95f,
                            Publisher = "Signet",
                            Title = "Les Miserables"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
