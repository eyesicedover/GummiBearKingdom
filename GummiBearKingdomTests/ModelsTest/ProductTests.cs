using GummiBearKingdom.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GummiBearKingdomTests
{
    [TestClass]
    public class ProductTests : IDisposable
    {
        private GBKTestContext db = new GBKTestContext();
        public void Dispose()
        {
            Product.ClearAll();
        }

        public ProductTests()
        {
            DBConfiguration.ConnectionString = "server=localhost;user id=root;password=root;port=8889;database=gbk_test;";
        }
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
