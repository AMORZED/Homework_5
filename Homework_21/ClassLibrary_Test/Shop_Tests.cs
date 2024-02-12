using ClassLibrary;
using ClassLibrary.Interfaces;
using Moq;
using NUnit.Framework.Internal;
using ClassLibrary.Classes;

namespace ClassLibrary_Test
{
    [TestFixture]
    internal class Shop_Tests
    {
        [Test]
        public void Shop_Test()
        {
            var ilMock = new Mock<ClassLibrary.Interfaces.ILogger>();
            var isdMock = new Mock<IShopDiscounter>();
            var itMock = new Mock<IItem>();
            var idbMock = new Mock<IDb>();

            Shop shop = new Shop(isdMock.Object, ilMock.Object, itMock.Object, idbMock.Object);

            ilMock.VerifyAll();
            itMock.VerifyAll();
            idbMock.VerifyAll();
            isdMock.VerifyAll();
        }

        [Test]
        public void BuyItem_Test()
        {

        }

        [Test]
        public void BuyItemWithDiscount_Test()
        {

        }
    }
}
