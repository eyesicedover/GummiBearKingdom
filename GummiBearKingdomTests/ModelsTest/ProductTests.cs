using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GummiBearKingdom.Models;

namespace Tests.ModelsTest
{
    [TestClass]
    public class ProductTests
    {
        [TestMethod]
        public void Product_Constructor_Test()
        {
            //Arrange
            string description = "lil bits of black licorice";

            //Act
            Product newProduct = new Product("Black Licorice", description, 2.44);
            newProduct.ProductId = 1;
            newProduct.Reviews = null;

            //Assert
            Assert.AreEqual(description, newProduct.Description);
        }

        [TestMethod]
        public void GetAverageRating_Test()
        {
            //Arrange
            Product newProduct = new Product("Black Licorice", "lil bits of black licorice", 2.44);
            newProduct.ProductId = 1;
            List<Review> theReviews = new List<Review>
            {
                new Review("Jerry", "Love dat flavor", 5),
                new Review("Sam", "Made me yartz", 1),
                new Review("Claire", "Pretty good", 3)
            };
            newProduct.Reviews = theReviews;

            //Act
            double result = newProduct.GetAverageRating();

            Assert.AreEqual(3, result);
        }
    }
}
