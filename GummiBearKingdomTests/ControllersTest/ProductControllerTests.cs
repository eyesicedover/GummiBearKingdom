using GummiBearKingdom.Controllers;
using GummiBearKingdom.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace GummiBearKingdomTests
{
    [TestClass]
    public class ProductControllerTests
    {
        mock.Setup(m => m.Products).Returns(new Product[]
        {
            new Product {ProductId = 1, Name = "1lb Gummy Bear", Cost= 10, Description="BIG OLE BEAR" },
            new Product {ProductId = 2, Name = "Chocolate Frog", Cost= 3, Description="Chocolate in frog shape" ,
            new Product {ProductId = 3, Name = "1lb Gummy Bear", Cost= 4, Description="BIG OLE BEAR" 
        }.AsQueryable());

        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            Mock<IProductRepository> mock = new Mock<IProductRepository>();
        }
    }
}
