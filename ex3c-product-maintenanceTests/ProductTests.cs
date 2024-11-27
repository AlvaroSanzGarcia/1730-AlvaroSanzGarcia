namespace ex3c_product_maintenance.Tests
{
    [TestClass()]
    public class ProductTests
    {
        Product product = new("ABC", "New Product", 35.0m);

        [TestMethod()]
        public void ProductTest()
        {  
            Assert.IsNotNull(product);
            Assert.IsNotNull(product.Code);
            Assert.IsNotNull(product.Description);
            Assert.IsNotNull(product.Price);
            Assert.AreEqual(product.Code, "ABC");
            Assert.AreEqual(product.Description, "New Product");
            Assert.AreEqual(product.Price, 35.0m);
        }

        [TestMethod()]
        public void ToStringTest()
        {            
            Assert.AreEqual(product.ToString(), "ABC\t$35.00\tNew Product");
        }
    }
}