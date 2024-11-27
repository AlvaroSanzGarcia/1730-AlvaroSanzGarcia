namespace ex3c_product_maintenance.Tests
{     
    [TestClass()]
    public class BookTests
    {
        Book book = new Book("ABC", "New Book", 27.0m, "Joel Murach");

        [TestMethod()]
        public void BookTest()
        {
            Assert.IsNotNull(book);
            Assert.IsNotNull(book.Code);
            Assert.IsNotNull(book.Description);
            Assert.IsNotNull(book.Price);
            Assert.IsNotNull(book.Author);
            Assert.AreEqual(book.Code, "ABC");
            Assert.AreEqual(book.Description, "New book");
            Assert.AreEqual(book.Price, 27.0m);
            Assert.AreEqual(book.Author, "Joel Murach");
        }

        [TestMethod()]
        public void ToStringTest()
        {
            Assert.AreEqual(book.ToString(), "ABC\t$27.00\tNew Book (Joel Murach)");
        }
    }
}