namespace ProductService.Models
{
    public class Product
    {
        public int Id { get; set; } //Primary Key
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
