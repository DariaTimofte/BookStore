using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BookStoreApp.Entities;

namespace BookStoreApp.Data
{
    public class BookStoreDbContext : DbContext
    {
        public BookStoreDbContext(DbContextOptions<BookStoreDbContext> options) : base(options) { }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<FidelityBonus> FidelityBonus { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderBooks> OrderBooks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //one-to-many
            modelBuilder.Entity<Client>()
                .HasOne<Role>(s => s.Role)
                .WithMany(g => g.Clients)
                .HasForeignKey(s => s.RoleId);

            modelBuilder.Entity<Role>()
                .HasMany<Client>(s => s.Clients)
                .WithOne(g => g.Role)
                .HasForeignKey(s => s.RoleId);

            modelBuilder.Entity<Book>()
                .HasOne<Author>(s => s.Author)
                .WithMany(g => g.Books)
                .HasForeignKey(s => s.AuthorId);

            modelBuilder.Entity<Book>()
                .HasOne<Category>(s => s.Category)
                .WithMany(g => g.Books)
                .HasForeignKey(s => s.CategoryId);

            modelBuilder.Entity<Order>()
                .HasOne<Client>(s => s.Client)
                .WithMany(g => g.Orders)
                .HasForeignKey(s => s.ClientId);

            //one-to-one
            modelBuilder.Entity<Client>()
                .HasOne<FidelityBonus>(s => s.FidelityBonus);

            //many-to-many
            modelBuilder.Entity<OrderBooks>()
                .HasKey(sc => new { sc.BookId, sc.OrderId });

            modelBuilder.Entity<OrderBooks>()
                .HasOne<Order>(sc => sc.Order)
                .WithMany(s => s.OrderBooks)
                .HasForeignKey(sc => sc.OrderId);


            modelBuilder.Entity<OrderBooks>()
                .HasOne<Book>(sc => sc.Book)
                .WithMany(s => s.OrderBooks)
                .HasForeignKey(sc => sc.BookId);
        }
    }
}
