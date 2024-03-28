﻿namespace TRANTHEBAO1_2180605748.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; } 
        public string? ImageUrl { get; set; }
        public List<ProductImage>? Images { get; set; }
        public int CategoryId {  get; set; }
        public Category? category { get; set; }
    }
}
