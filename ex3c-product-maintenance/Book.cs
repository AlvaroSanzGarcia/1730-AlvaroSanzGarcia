namespace ex3c_product_maintenance
{
    public class Book : Product
    {
        public string Author { get; set; }

        public Book(string? code, string? description, decimal price, string author)
            : base(code, description, price) =>

            Author = author;

        public override string ToString() =>
            
            $"{base.ToString()} ({Author })";
        
    }
}
