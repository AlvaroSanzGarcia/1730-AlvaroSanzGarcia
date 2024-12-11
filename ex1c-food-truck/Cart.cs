namespace ex1c_food_truck
{
    public class Cart
    {
        static decimal productTotal;
        static decimal pretaxTotal;
        static decimal taxTotal;
        static decimal totalAfterTax;
        static List<decimal> cart = new List<decimal>();


        public static decimal GetProductTotal(int amount, decimal price) 
        {
            productTotal = amount * price;
            cart.Add(productTotal);
            return productTotal;
        } 
        

        public static decimal GetPretaxTotal() 
        {
            foreach (decimal cartTotals in cart) 
            { 
                pretaxTotal += cartTotals;
            }
            
            return pretaxTotal; 
        }


        public static decimal GetTaxTotal() 
        {
            taxTotal = pretaxTotal * 0.0687m;
            return taxTotal;
        }


        public static decimal GetTotalAfterTax() 
        {
            totalAfterTax = pretaxTotal + taxTotal;
            return totalAfterTax;
        }


        public static void ResetCart() 
        {
            cart.Clear();
            pretaxTotal = 0;
            taxTotal = 0;
            totalAfterTax = 0;
        }
    }
}
