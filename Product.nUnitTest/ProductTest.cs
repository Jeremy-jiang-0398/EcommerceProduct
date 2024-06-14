namespace Ecommerce_Product.nUnitTest
{
    public class ProductTest
    {
        private Product _product { get; set; }
        [SetUp]
        public void Setup()
        {
            _product = new Product(1, "Very First", 100, 100);

        }
        //ProductId Test

        [Test]
        [TestCase(1)]
        [TestCase(500)]
        [TestCase(1000)]
        public void ProductIdTest(int id)
        {
            //Arrange
            Product New_Product = new Product(id, "xxx", 10, 10);

            //Act
            int IdTest = New_Product.ProductID;

            //Assert
            Assert.That(Equals(id, IdTest));
        }

        //ProductName Test
        [Test]
        [TestCase("Chicken")]
        [TestCase("Beef")]
        [TestCase("Lamb")]

        public void ProductName(string name)
        {
            //Arrange
            Product New_Product = new Product(1, name, 10, 10);

            //Act 
            string NameTest = New_Product.ProductName;

            //Assert
            Assert.That(Equals(name, NameTest));
        }

        //Product Price Test

        [Test]
        [TestCase(1.0)]
        [TestCase(300.9)]
        [TestCase(5000.0)]


        public void PriceTest(decimal price)
        {
            //Arrange
            Product New_Product = new Product(1, "Beef", price, 100);

            //Act
            decimal priceTest = New_Product.Price;

            //Assert
            Assert.That(Equals(price, priceTest));
        }

        //Product Stock Test

        [Test]
        [TestCase(10)]
        [TestCase(150)]
        [TestCase(1000)]
        public void StockTest(int stock)
        {
            //Arrange
            Product New_Product = new Product(1, "Beef", 11, stock);

            //Act
            int stockTest = New_Product.Stock;

            //Assert
            Assert.That(Equals(stock, stockTest));
        }

        //Product Increase Stock Test

        [Test]
        [TestCase(1)]
        [TestCase(500)]
        [TestCase(899)]
        public void IncreaseStockTest(int increaseStock)
        {

            //Arrange
            int newStock = 100 + increaseStock;

            //Act
            _product.IncreaseStock(increaseStock);

            //Assert
            Assert.That(Equals(_product.Stock, newStock));
        }

        // Produce Decrease Stock Test

        [Test]
        [TestCase(1)]
        [TestCase(60)]
        [TestCase(100)]
        public void DecreaseStockTest(int decreaseStock)
        {
            //Arrange
            int newStock = 100 - decreaseStock;

            //Act
            _product.DecreaseStock(decreaseStock);

            //Assert
            Assert.That(Equals(_product.Stock, newStock));
        }
    }
}