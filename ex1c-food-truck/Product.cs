namespace ex1c_food_truck
{
    public class Product
    {
        public Product() { }
        public Product (int amount, decimal price) 
        {
            this.Amount = amount;
            this.Price = price;
        }
        public int Amount { get; set; }
        public decimal Price { get; set; }
        
    }
}
