using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data
{
    public class EShopDbContext : DbContext
    {
        public EShopDbContext(DbContextOptions<EShopDbContext> options) : base(options)
        {
            // Constructor body, if needed
        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<PaymentType> PaymentTypes { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<OrderStatus> OrderStatuses { get; set; }
        public DbSet<CustomerReview> CustomerReviews { get; set; }
        public DbSet<PromotionSale> PromotionSales { get; set; }
        public DbSet<PromotionDetails> PromotionDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>(ConfigureAddress);
            modelBuilder.Entity<Customer>(ConfigureCustomer);
            modelBuilder.Entity<ShoppingCart>(ConfigureShoppingCart);
            modelBuilder.Entity<ShoppingCartItem>(ConfigureShoppingCartItem);
            modelBuilder.Entity<PaymentMethod>(ConfigurePaymentMethod);
            modelBuilder.Entity<PaymentType>(ConfigurePaymentType);
            modelBuilder.Entity<Order>(ConfigureOrder);
            modelBuilder.Entity<OrderDetails>(ConfigureOrderDetails);
            modelBuilder.Entity<OrderStatus>(ConfigureOrderStatus);
            modelBuilder.Entity<CustomerReview>(ConfigureCustomerReview);
            modelBuilder.Entity<PromotionSale>(ConfigurePromotionSale);
            modelBuilder.Entity<PromotionDetails>(ConfigurePromotionDetails);
        }

        private void ConfigureAddress(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable("Address");
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Street1).HasMaxLength(128);
            builder.Property(a => a.Street2).HasMaxLength(128);
            builder.Property(a => a.City).HasMaxLength(64);
            builder.Property(a => a.State).HasMaxLength(64);
            builder.Property(a => a.Country).HasMaxLength(64);
            builder.Property(a => a.IsDefaultAddress).HasDefaultValue(false);
            builder.HasOne(a => a.Customer)
                   .WithMany(c => c.Addresses)
                   .HasForeignKey(a => a.CustomerId);
        }

        private void ConfigureCustomer(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customer");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.FirstName).HasMaxLength(128);
            builder.Property(c => c.LastName).HasMaxLength(128);
            builder.Property(c => c.Gender).HasMaxLength(16);
            builder.Property(c => c.Phone).HasMaxLength(16);
            builder.Property(c => c.ProfilePic).HasMaxLength(256);
        }

        private void ConfigureShoppingCart(EntityTypeBuilder<ShoppingCart> builder)
        {
            builder.ToTable("ShoppingCart");
            builder.HasKey(sc => sc.Id);
            builder.HasOne(sc => sc.Customer)
                   .WithMany(c => c.ShoppingCarts)
                   .HasForeignKey(sc => sc.CustomerId);
        }

        private void ConfigureShoppingCartItem(EntityTypeBuilder<ShoppingCartItem> builder)
        {
            builder.ToTable("ShoppingCartItem");
            builder.HasKey(sci => sci.Id);
            builder.Property(sci => sci.ProductName).HasMaxLength(256);
            builder.HasOne(sci => sci.ShoppingCart)
                   .WithMany(sc => sc.ShoppingCartItems)
                   .HasForeignKey(sci => sci.CartId);
        }

        private void ConfigurePaymentMethod(EntityTypeBuilder<PaymentMethod> builder)
        {
            builder.ToTable("PaymentMethod");
            builder.HasKey(pm => pm.Id);
            builder.Property(pm => pm.Provider).HasMaxLength(128);
            builder.Property(pm => pm.AccountNumber).HasMaxLength(64);
            builder.HasOne(pm => pm.PaymentType)
                   .WithMany(pt => pt.PaymentMethods)
                   .HasForeignKey(pm => pm.PaymentTypeId);
        }

        private void ConfigurePaymentType(EntityTypeBuilder<PaymentType> builder)
        {
            builder.ToTable("PaymentType");
            builder.HasKey(pt => pt.Id);
            builder.Property(pt => pt.Name).HasMaxLength(128);
        }

        private void ConfigureOrder(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Order");
            builder.HasKey(o => o.Id);
            builder.Property(o => o.CustomerName).HasMaxLength(256);
            builder.Property(o => o.PaymentName).HasMaxLength(256);
            builder.Property(o => o.ShippingAddress).HasMaxLength(512);
            builder.Property(o => o.ShippingMethod).HasMaxLength(128);
            builder.HasOne(o => o.PaymentMethod)
                   .WithMany(pm => pm.Orders)
                   .HasForeignKey(o => o.PaymentMethodId);
            builder.HasOne(o => o.OrderStatus)
                   .WithMany(os => os.Orders)
                   .HasForeignKey(o => o.OrderStatusId);
        }

        private void ConfigureOrderDetails(EntityTypeBuilder<OrderDetails> builder)
        {
            builder.ToTable("OrderDetails");
            builder.HasKey(od => od.Id);
            builder.Property(od => od.ProductName).HasMaxLength(256);
            builder.HasOne(od => od.Order)
                   .WithMany(o => o.OrderDetails)
                   .HasForeignKey(od => od.OrderId);
        }

        private void ConfigureOrderStatus(EntityTypeBuilder<OrderStatus> builder)
        {
            builder.ToTable("OrderStatus");
            builder.HasKey(os => os.Id);
            builder.Property(os => os.Name).HasMaxLength(64);
            builder.Property(os => os.Description).HasMaxLength(256);
        }

        private void ConfigureCustomerReview(EntityTypeBuilder<CustomerReview> builder)
        {
            builder.ToTable("CustomerReview");
            builder.HasKey(cr => cr.Id);
            builder.Property(cr => cr.CustomerName).HasMaxLength(256);
            builder.Property(cr => cr.ProductName).HasMaxLength(256);
            builder.Property(cr => cr.Comment).HasMaxLength(1024);
            builder.HasOne(cr => cr.Customer)
                   .WithMany(c => c.CustomerReviews)
                   .HasForeignKey(cr => cr.CustomerId);
            builder.HasOne(cr => cr.Order)
                   .WithMany(o => o.CustomerReviews)
                   .HasForeignKey(cr => cr.OrderId);
            builder.HasOne(cr => cr.Product)
                   .WithMany(p => p.CustomerReviews)
                   .HasForeignKey(cr => cr.ProductId);
        }

        private void ConfigurePromotionSale(EntityTypeBuilder<PromotionSale> builder)
        {
            builder.ToTable("PromotionSale");
            builder.HasKey(ps => ps.Id);
            builder.Property(ps => ps.Name).HasMaxLength(128);
            builder.Property(ps => ps.Description).HasMaxLength(256);
            builder.Property(ps => ps.Discount).HasColumnType("decimal(5,2)");
        }

        private void ConfigurePromotionDetails(EntityTypeBuilder<PromotionDetails> builder)
        {
            builder.ToTable("PromotionDetails");
            builder.HasKey(pd => pd.Id);
            builder.HasOne(pd => pd.PromotionSale)
                   .WithMany(ps => ps.PromotionDetails)
                   .HasForeignKey(pd => pd.PromotionId);
            builder.HasOne(pd => pd.ProductCategory)
                   .WithMany(pc => pc.PromotionDetails)
                   .HasForeignKey(pd => pd.ProductCategoryId);
        }
    }
}

