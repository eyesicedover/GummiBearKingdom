using GummiBearKingdom.Controllers;
using GummiBearKingdom.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace GummiBearKingdom.Tests.ControllerTests
{
    [TestClass]
    public class ReviewControllerTests
    {
            Mock<IReviewRepository> mock = new Mock<IReviewRepository>();
        private void DbSetup()
        {
            mock.Setup(m => m.Reviews).Returns(new Review[]
            {
                new Review {ReviewId = 1, ProductId = 1, Author = "Michael", Content= "Tastes great", Rating=4 },
                new Review {ReviewId = 2, ProductId = 1, Author = "Carrie", Content= "Not my favorite", Rating=2 },
                new Review {ReviewId = 3, ProductId = 2, Author = "Rosa", Content= "Best candy you make!", Rating=5 }
            }.AsQueryable());
        }
       /* 
        [TestMethod]
        public void ReviewController_CreatePost()
        {
            // Arrange
            Review testReview = new Review
            {
                ProductId = 2,
                ReviewId = 4,
                Author = "Qui-Gon",
                Content = "UHHHHH good",
                Rating=4
            };

            DbSetup();
            ReviewsController controller = new ReviewsController(mock.Object);

            // Act
            var resultView = controller.Create();

            // Assert
            Assert.IsInstanceOfType(resultView, typeof(RedirectToActionResult));

        }
        */

    }
}
