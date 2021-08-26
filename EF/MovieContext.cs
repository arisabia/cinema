using Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EF
{
    public class MovieContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public MovieContext(DbContextOptions<MovieContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuider)
        {
            modelBuider.Entity<Movie>().ToTable("Movie").HasKey(k => k.Id);
            modelBuider.Entity<Movie>().Property(n => n.Name).IsRequired().HasMaxLength(50);
            modelBuider.Entity<Movie>().Property(n => n.Length).IsRequired();
            modelBuider.Entity<Movie>().Property(n => n.Type).IsRequired();
            modelBuider.Entity<Movie>().Property(n => n.ReleaseDate).IsRequired();

            modelBuider.Entity<Account>().ToTable("Users")
                                           .HasKey(k => k.Id);
            modelBuider.Entity<Account>().Property(p => p.Username)
                                           .IsRequired();
            modelBuider.Entity<Account>().Property(p => p.Password)
                                          .IsRequired();
            modelBuider.Entity<Account>().Property(p => p.Role)
                                          .IsRequired();
            modelBuider.Entity<Account>().HasData(
                new Account
                {
                    Id = 1,
                    Username = "mrossi@abc.it",
                    Password = "1234",
                    Role = Role.Administrator
                },
                new Account
                {
                    Id = 2,
                    Username = "larisa@abc.it",
                    Password = "1234",
                    Role = Role.User
                }

                );
        }

    }
}
