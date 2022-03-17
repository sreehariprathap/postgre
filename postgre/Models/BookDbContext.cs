using DotnetandPostgresql.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace postgre.Models
{
    public class BookDbContext : DbContext
    {
        public BookDbContext(DbContextOptions<BookDbContext> options) : base(options) { }
        public DbSet<Books> books { get; set; }
        public DbSet<Author> authors { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Books>().HasData(
                new Books() { Id = 1, Name = "Ikigai", Description = "japanese", Price = 10000, AuthorFK = 1 },
                new Books() { Id = 2, Name = "rich dad poor dad", Description = "money", Price = 50000, AuthorFK = 2 },

                new Books() { Id = 3, Name = "anxious people", Description = "novel", Price = 20000, AuthorFK = 3 });
            ;

            modelBuilder.Entity<Author>().HasData(
               new Author() { AuthorID = 1, AuthorName = "sreehari" },
               new Author() { AuthorID = 2, AuthorName = "nikhil" },
               new Author() { AuthorID = 3, AuthorName = "akhil" }
               );
           
        }
    }
}
