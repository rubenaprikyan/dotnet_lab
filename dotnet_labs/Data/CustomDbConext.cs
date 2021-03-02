using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_labs.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnet_labs.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<AuthorModel> Authors { get; set; }
        public DbSet<GenreModel> Genres { get; set; }
        public DbSet<BookModel> Books { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AuthorModel>()
                .HasMany(p => p.Books)
                .WithOne()
                .HasForeignKey(p => p.AuthorId);
            
            modelBuilder.Entity<GenreModel>()
                .HasMany(p => p.Books)
                .WithOne()
                .HasForeignKey(p => p.GenreID);
        }
    }
}
