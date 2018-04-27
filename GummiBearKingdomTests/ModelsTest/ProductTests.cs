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

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
