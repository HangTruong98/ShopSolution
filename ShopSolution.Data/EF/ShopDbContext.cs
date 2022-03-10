using Microsoft.EntityFrameworkCore;
using ShopSolution.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopSolution.Data.EF
{
    public class ShopDbContext : DbContext
    {
        public ShopDbContext( DbContextOptions options) : base(options)
        {
           

        }
        public DbSet<Product> Products { set; get; }
        public DbSet<Category> Categories { set; get; }

        public DbSet<Cart> Carts { set; get; }
        public DbSet<Order> Orders { set; get; }
        public DbSet<OrderDetail> OrderDetails { set; get; }
        public DbSet<Transaction> Transactions { set; get; }
        public DbSet<ProductTranslation> ProductTranslations { set; get; }
        public DbSet<CategoryTranslation> CategoryTranslations { set; get; }
        public DbSet<Promotion> Promotions { set; get; }
        public DbSet<SystemActivity> SystemActivities { set; get; }
        public DbSet<Contact> Contacts { set; get; }
        public DbSet<Language> Languages { set; get; }
        public DbSet<AppConfig> AppConfigs { set; get; }
    }
}
