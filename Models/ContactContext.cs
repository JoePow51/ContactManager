using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ContactManager.Models
{
    public class ContactContext : DbContext
    {
        public ContactContext(DbContextOptions<ContactContext> options)
            : base(options)
        { }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<Contact>().HasData(
                new Contact
                {
                    ContactId = 1,
                    Firstname = "Delores",
                    Lastname = "Del Rio",
                    Phone ="5559876543",
                    Email = "delores@hotmail.com",
                    CategoryId = 2,
                    Organization = "Test Org",
                },
                new Contact
                {
                    ContactId = 2,
                    Firstname = "Efren",
                    Lastname = "Herrera",
                    Phone = "5554567890",
                    Email = "efren@aol.com",
                    CategoryId = 3,
                    Organization = "Test Org 2",
                },
                new Contact
                {
                    ContactId = 3,
                    Firstname = "Mary Ellen",
                    Lastname = "Walton",
                    Phone = "5551234567",
                    Email = "MaryEllen@yahoo.com",
                    CategoryId = 1,
                    Organization = "Test Org 3",
                }
            );

            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Family" },
                new Category { CategoryId = 2, Name = "Friend" },
                new Category { CategoryId = 3, Name = "Work" }
            );

        }
    }
}
