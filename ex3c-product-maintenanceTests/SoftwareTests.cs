namespace ex3c_product_maintenance.Tests
{
    [TestClass()]
    public class SoftwareTests
    {
        Software software = new Software("ABC", "New Software Product", 55.9m, "5.2");

        [TestMethod()]
        public void SoftwareTest()
        {            
            Assert.IsNotNull(software);
            Assert.IsNotNull(software.Code);
            Assert.IsNotNull(software.Description);
            Assert.IsNotNull(software.Price);
            Assert.IsNotNull(software.Version);
            Assert.AreEqual(software.Code, "ABC");
            Assert.AreEqual(software.Description, "New Software Product");
            Assert.AreEqual(software.Price, 55.9m);
            Assert.AreEqual(software.Version, "5.2");
        }

        [TestMethod()]
        public void ToStringTest()
        {
            Assert.AreEqual(software.ToString(), "ABC\t$55.90\tNew Software Product, Version 5.2");
        }
    }
}