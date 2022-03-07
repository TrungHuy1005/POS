using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.SqlServerCompact;
using System.Linq;
using System.Web;
using Microsoft.Extensions.Options;
using MySql.Data.EntityFramework;
using POS.Domain.Models;

namespace POS.Data.Context
{
    public class OnlineShopDbContext: DbContext
    {
        public OnlineShopDbContext() : base("OnlineShopDb")
        {
        }
        public DbSet<Bill> Bill { get; set; }
        public DbSet<CartProduct> CartProduct { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Product> Product { get; set; }
        protected override void OnModelCreating(DbModelBuilder builder)
        {
            Database.SetInitializer<OnlineShopDbContext>(null);
            base.OnModelCreating(builder);
            builder.Entity<Bill>();
            builder.Entity<CartProduct>();
            builder.Entity<Category>();
            builder.Entity<Customer>();
            builder.Entity<Employee>();
            builder.Entity<Product>();
        }
    }
}