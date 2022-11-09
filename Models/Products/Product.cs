using System;
using System.Collections.Generic;

namespace ProductsMvcDbFirst.Models.Products
{
    public partial class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Brand { get; set; }
        public decimal WholesaleCost { get; set; }
        public decimal Price { get; set; }
        public int CurrentStock { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
