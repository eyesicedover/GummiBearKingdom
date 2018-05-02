using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GummiBearKingdom.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GummiBearKingdom.Controllers
{
    public class ReviewsController : Controller
    {
        private IReviewRepository reviewRepo;

        public ReviewsController(IReviewRepository repo = null)
        {
            if (repo == null)
            {
                this.reviewRepo = new EFReviewRepository();
            }
            else
            {
                this.reviewRepo = repo;
            }
        }

        [HttpPost]
        public IActionResult Create()
        {
            Review review = new Review();
            review.Author = Request.Form["author"];
            review.Content = Request.Form["content"];
            review.ProductId = int.Parse(Request.Form["productId"]);
            review.Rating = Convert.ToDouble(int.Parse(Request.Form["rating"]));
            reviewRepo.Save(review);
            return RedirectToAction("Details", "Products", new { id = review.ProductId });
        }
    }
}
