using Moq;
using ClassLibrary.Classes;
using ClassLibrary.Interfaces;

namespace ClassLibrary_Test
{
    [TestFixture]
    internal class ShopDiscounter_Tests
    {
        [Test]
        public void AddDiscountToItem_Test()
        {
            var iLoggerMock = new Mock<ILogger>();
            ShopDiscounter shopDiscounter = new ShopDiscounter(iLoggerMock.Object);

            ShopItem item = new ShopItem("Вещь", 100M);
            var actual = shopDiscounter.AddDiscountToItem(item, 50);
            decimal expected = 50M;

            Console.WriteLine(actual);
            Assert.That(actual.Price.Equals(expected));
        }

        [Test]
        public void ShopDiscounter_Test()
        {
            var dbMock = new Mock<IDb>();

            ShopLogger sLogger = new ShopLogger(dbMock.Object);

            dbMock.VerifyAll();
        }
    }
}
