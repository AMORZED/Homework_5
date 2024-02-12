using ClassLibrary.Classes;
using ClassLibrary.Interfaces;
using Moq;
using NUnit.Framework.Internal;
using System.Security;

namespace ClassLibrary_Test
{
    [TestFixture]
    internal class ShopLoggerTests
    {
        [Test]
        public void ShopLogger_Test()
        {
            var dbMock = new Mock<IDb>();
            ShopLogger shopLogger = new ShopLogger(dbMock.Object);

            dbMock.VerifyAll();
        }

        [Test]
        public void Warn_Test()
        {
            string message = "Test";

            var dbMock = new Mock<IDb>();
            dbMock.Setup(x => x.AddLogRecord(It.IsAny<string>()));
            ShopLogger shopLogger = new ShopLogger(dbMock.Object);

            shopLogger.Warn(message);

            dbMock.Verify(x => x.AddLogRecord($"WARN: {message}"));
        }

        [Test]
        public void Info_Test()
        {
            string message = "Test";

            var dbMock = new Mock<IDb>();
            dbMock.Setup(x => x.AddLogRecord(It.IsAny<string>()));
            ShopLogger shopLogger = new ShopLogger(dbMock.Object);

            shopLogger.Info(message);

            dbMock.Verify(x => x.AddLogRecord($"INFO: {message}"));
        }
        
        [Test]
        public void IsAvailable_Test() 
        { 
            var dbMock = new Mock<IDb>();
            dbMock.Setup(x => x.IsAvailable());
            ShopLogger shopLogger = new ShopLogger(dbMock.Object);
            var actual = shopLogger.IsAvailable();

            shopLogger.IsAvailable();

            dbMock.Verify(x => x.IsAvailable());
        }        
    }
}
