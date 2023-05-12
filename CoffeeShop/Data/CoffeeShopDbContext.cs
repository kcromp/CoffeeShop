﻿using CoffeeShop.Models;
using Microsoft.EntityFrameworkCore;

namespace CoffeeShop.Data
{
    public class CoffeeShopDbContext : DbContext
    {
        public CoffeeShopDbContext(DbContextOptions<CoffeeShopDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasData(
                
                new Product { Id = 1, Name = "Americano", Detail = "The Americano coffee is a classic espresso-based drink.", Price = 7, IsTrendingProduct = true, ImageUrl = "https://images.unsplash.com/photo-1495474472287-4d71bcdd2085?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8Nnx8Y29mZmVlfGVufDB8fDB8fA%3D%3D&auto=format&fit=crop&w=500&q=60" },
                new Product { Id = 2, Name = "Cortado", Detail = "Cortado coffee is a traditional Spanish coffee beverage.", Price = 9, IsTrendingProduct = true, ImageUrl = "https://images.unsplash.com/photo-1495474472287-4d71bcdd2085?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8Nnx8Y29mZmVlfGVufDB8fDB8fA%3D%3D&auto=format&fit=crop&w=500&q=60" },
                new Product { Id = 3, Name = "Mocha", Detail = "Mocha coffee is a rich and creamy blend.", Price = 8, IsTrendingProduct = true, ImageUrl = "https://images.unsplash.com/photo-1495474472287-4d71bcdd2085?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8Nnx8Y29mZmVlfGVufDB8fDB8fA%3D%3D&auto=format&fit=crop&w=500&q=60" },
                new Product { Id = 4, Name = "Macchiato", Detail = "Macchiato coffee is a classic beverage that is rich and creamy.", Price = 8, IsTrendingProduct = true, ImageUrl = "https://images.unsplash.com/photo-1495474472287-4d71bcdd2085?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8Nnx8Y29mZmVlfGVufDB8fDB8fA%3D%3D&auto=format&fit=crop&w=500&q=60" },
                new Product { Id = 5, Name = "Flat White", Detail = "Flat White is a staple in the coffee drink arena.", Price = 8, IsTrendingProduct = true, ImageUrl = "https://images.unsplash.com/photo-1495474472287-4d71bcdd2085?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8Nnx8Y29mZmVlfGVufDB8fDB8fA%3D%3D&auto=format&fit=crop&w=500&q=60" },
                new Product { Id = 6, Name = "Decaf", Detail = "Coffee without caffine.", Price = 7, IsTrendingProduct = false, ImageUrl = "https://images.unsplash.com/photo-1495474472287-4d71bcdd2085?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8Nnx8Y29mZmVlfGVufDB8fDB8fA%3D%3D&auto=format&fit=crop&w=500&q=60" },
                new Product { Id = 7, Name = "Irish Coffee", Detail = "Irish coffee is a warm, comforting drink with bold flavor.", Price = 9, IsTrendingProduct = true, ImageUrl = "https://images.unsplash.com/photo-1495474472287-4d71bcdd2085?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8Nnx8Y29mZmVlfGVufDB8fDB8fA%3D%3D&auto=format&fit=crop&w=500&q=60" },
                new Product { Id = 8, Name = "Iced Coffee", Detail = "Iced coffee is a refreshing and delicious way to enjoy coffee.", Price = 7, IsTrendingProduct = false, ImageUrl = "https://images.unsplash.com/photo-1495474472287-4d71bcdd2085?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8Nnx8Y29mZmVlfGVufDB8fDB8fA%3D%3D&auto=format&fit=crop&w=500&q=60" }

                );
        }
    }
}
