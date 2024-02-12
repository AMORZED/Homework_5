using ClassLibrary.Classes;
using NUnit.Framework.Internal;

namespace ClassLibrary_Test
{
    [TestFixture]
    internal class ShopItem_Tests
    {
        [Test]
        public void ShopItem_Test()
        {
            ShopItem shopItem = new ShopItem("Test", 50M);

            var actual = shopItem;

            Assert.That(actual.Name.Equals("Test") & actual.Price.Equals(50M));
        }
    }
}
