using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace COA.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        //public DbSet<Post> Posts { get; set; }
        //public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            //optionsBuilder.UseSqlServer(@"Server=MUKESHTest;Database=Test2.1;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                    new User()
                    {
                        UserId = 1,
                        UserName = "shafqat"
                    },
                    new User()
                    {
                        UserId = 2,
                        UserName = "farhan"
                    }
                );

            modelBuilder.Entity<Post>().HasData(
                    new Post()
                    {
                        PostId = 1,
                        Title = "My first post",
                        Content = "My first post content",
                        CreatedOn = DateTime.Now,
                        UserId = 1
                    },
                    new Post()
                    {
                        PostId = 2,
                        Title = "My second post",
                        Content = "My second post content",
                        CreatedOn = DateTime.Now,
                        UserId = 1
                    }
                ) ;
        }
    }
}
