namespace ex1c_food_truck.Tests
{
    [TestClass()]
    public class CartTests
    {
        
        [TestMethod()]
        public void GetProductTotalTest()
        {
            Product sandwich = new Product(4, 6.99m);
            decimal productTotal = Cart.GetProductTotal(sandwich.Amount, sandwich.Price);
            Assert.AreEqual(productTotal, 27.96m);
            Cart.ResetCart();
        }

        [TestMethod()]
        public void GetPretaxTotalTest()
        {
            Cart.GetProductTotal(2, 2.5m);
            Cart.GetProductTotal(1, 5.5m);
            decimal preTaxTotal = Cart.GetPretaxTotal();
            Assert.AreEqual(preTaxTotal, 10.50m);
            Cart.ResetCart();
        }

        [TestMethod()]
        public void GetTaxTotalTest()
        {
            Cart.GetProductTotal(4, 4.99m);
            Cart.GetProductTotal(2, 3.60m);
            Cart.GetPretaxTotal();
            decimal taxTotal = Cart.GetTaxTotal();
            Assert.AreEqual(taxTotal, 1.865892m);
            Cart.ResetCart();
        }

        [TestMethod()]
        public void GetTotalAfterTaxTest()
        {
            Cart.GetProductTotal(1, 3.30m);
            Cart.GetProductTotal(2, 6.50m);
            Cart.GetPretaxTotal();
            Cart.GetTaxTotal();
            decimal totalAfterTax = Cart.GetTotalAfterTax();
            Assert.AreEqual(totalAfterTax, 17.41981m);
            Cart.ResetCart();
        }

        [TestMethod()]
        public void ResetCartTest()
        {
            Cart.GetProductTotal(4, 5m);
            Cart.ResetCart();
            decimal preTax = Cart.GetPretaxTotal();
            Assert.AreEqual(preTax, 0m);
        }
    }
}