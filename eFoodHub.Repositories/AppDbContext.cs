using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using eFoodHub.Entities;
using Microsoft.EntityFrameworkCore;

namespace eFoodHub.Repositories
{
    public class AppDbContext : IdentityDbContext<User, Role, int>
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<ItemType> ItemTypes { get; set; }
        public DbSet<Order> Orders{ get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<PaymentDetails> PaymentDetails { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //optionsBuilder.UseSqlServer(@"data source=DESKTOP-H9K9JVI\emrep;initial catalog=eFoodHubSite;integrated security=True;");

                optionsBuilder.UseSqlServer(@"data source=DESKTOP-H9K9JVI\emrep;initial catalog=eFoodHubSite; persist security info=True; user id = sa; password=1");
            }
            base.OnConfiguring(optionsBuilder); 
        }



    }
}
