using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GummiBearKingdom.Models;

namespace Tests.ModelsTest
{
    [TestClass]
    public class ReviewTests
    {
        [TestMethod]
        public void Review_Constructor_Test()
        {
            //Arrange
            string author = "Michael";

            //Act
            Review newReview = new Review(author, "Nice candy", 3.0);
            newReview.ProductId = 1;

            //Assert
            Assert.AreEqual(author, newReview.Author);

        }
    }
}
