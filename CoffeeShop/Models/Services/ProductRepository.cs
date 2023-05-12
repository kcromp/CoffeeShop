﻿using CoffeeShop.Models.Interfaces;

namespace CoffeeShop.Models.Services
{
    public class ProductRepository : IProductRepository
    {
        private List<Product> ProductList = new List<Product>()
        {
            new Product{Id = 1, Name = "Americano", Price = 25, Detail = "The Americano is a classic espresso-based drink that is simple.", ImageUrl = "", IsTrendingProduct = true},
            new Product{Id = 2, Name = "Mocha", Price = 25, Detail = "The Mocha offers rich chocolate flavor.", ImageUrl = "", IsTrendingProduct = false},
            new Product{Id = 3, Name = "Latte", Price = 25, Detail = "The Latte is a must-have choice.", ImageUrl = "", IsTrendingProduct = true}
        };

        public IEnumerable<Product> GetAllProducts()
        {
            return ProductList; 
        }

        public Product GetProductDetail(int id)
        {
            return ProductList.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Product> GetTrendingProducts()
        {
            return ProductList.Where(p => p.IsTrendingProduct);
        }
    }
}
