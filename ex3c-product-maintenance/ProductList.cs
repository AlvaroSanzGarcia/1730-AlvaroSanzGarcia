namespace ex3c_product_maintenance
{
    public class ProductList : List<Product>
    {
        public new void Add(Product product) => base.Add(product);

        public void LoadFromDatabase()
        {
            base.Add(new Book("JAVA", "Murach's Java Programming", 59.5m, "Joel Murach"));
            base.Add(new Software("NPTK", "NET Promgrammer's Toolkit", 179.99m, "4.5.2"));
            base.Add(new Software("NVLD", "NET Validation Library", 79.5m, "1.5.2"));
            base.Add(new Book("C#", "Murach's C#", 55.9m, "Anne Bohem"));
        }
    }

    
}
