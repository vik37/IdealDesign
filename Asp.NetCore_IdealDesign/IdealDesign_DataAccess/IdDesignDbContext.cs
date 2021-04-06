using IdealDesign_Domain.Enums;
using IdealDesign_Domain.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace IdealDesign_DataAccess
{
    public class IdDesignDbContext : IdentityDbContext<User>
    {
        public IdDesignDbContext(DbContextOptions options)
            : base(options) { }

        public DbSet<Product> Product { get; set; }
        public DbSet<ProductOrder> ProductOrder { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Career> Career { get; set; }

        public void Seed(ModelBuilder modelBuilder)
        {
            string adminId = Guid.NewGuid().ToString();
            string roleId = Guid.NewGuid().ToString();
            string userRoleId = Guid.NewGuid().ToString();

            modelBuilder.Entity<IdentityRole>()
                .HasData(new IdentityRole
                {
                    Id = roleId,
                    Name = "admin",
                    NormalizedName = "ADMIN"
                },
                new IdentityRole 
                {
                    Id = userRoleId,
                    Name = "user",
                    NormalizedName = "USER"
                });
            var hasher = new PasswordHasher<User>();

            modelBuilder.Entity<User>()
                .HasData(new User
                {
                    Id = adminId,
                    UserName = "vlatko77",
                    NormalizedUserName = "VLATKO77",
                    Email = "IdealDesignInterior@outlook.com",
                    NormalizedEmail = "IdealDesignInterior@outlook.com",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "BigCheese12#"),
                    SecurityStamp = string.Empty
                    
                });

            modelBuilder.Entity<IdentityUserRole<string>>()
                .HasData(new IdentityUserRole<string>
                {
                    RoleId = roleId,
                    UserId = adminId
                });           
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ProductOrder>()
                .HasKey(po => new { po.ProductId, po.OrderId });

            modelBuilder.Entity<User>()
                .HasMany(x => x.Orders)
                .WithOne(x => x.User)
                .HasForeignKey(x => x.UserId);

            modelBuilder.Entity<Order>()
                .HasMany(o => o.ProductOrders)
                .WithOne(po => po.Order)
                .HasForeignKey(po => po.OrderId);

            modelBuilder.Entity<Product>()
                .HasMany(p => p.ProductOrders)
                .WithOne(p => p.Product)
                .HasForeignKey(p => p.ProductId);

            Seed(modelBuilder);
        }

    }
}
