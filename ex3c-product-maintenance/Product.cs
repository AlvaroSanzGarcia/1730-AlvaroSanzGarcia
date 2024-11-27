namespace ex3c_product_maintenance
{
    public class Product
    {
        public string? Code { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }

        public Product (string? code, string? description, decimal price) => 
            (Code, Description, Price) = (code, description, price);

        public override string ToString() => $"{Code}\t{Price.ToString("c")}\t{Description}";
    }
}
