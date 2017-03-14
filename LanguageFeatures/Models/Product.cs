﻿namespace LanguageFeatures.Models
{
    public class Product
    {
        public Product(bool stock = true)
        {
            InStock = stock;
        }

        public string Name { get; set; }
        public string Category { get; set; } = "Watersports";
        public decimal? Price { get; set; }
        public Product Related { get; set; }
        public bool InStock { get; }
        public bool NameBeginsWithS => Name?[0] == 's';

        public static Product[] GetProducts()
        {
            Product kayak = new Product { Name = "Kayak", Category = "Water Craft", Price = 275m };
            Product lifejacket = new Product(false) { Name = "Lifejacket", Price = 48.95m };

            kayak.Related = lifejacket;

            return new Product[] { kayak, lifejacket, null };
        }
    }
}