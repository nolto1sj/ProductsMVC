namespace ProductsMvcDbFirst.Models.Products
{
    public class ProductDetails
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Brand { get; set; }
        public decimal WholesaleCost { get; set; }
        public decimal Price { get; set; }
        public int CurrentStock { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
