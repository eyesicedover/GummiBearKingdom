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
    public class ProductsController : Controller
    {
        private IProductRepository productRepo;
        private IReviewRepository reviewRepo;

        public ProductsController(IProductRepository repo = null, IReviewRepository revRepo = null)
        {
            if (repo == null)
            {
                this.productRepo = new EFProductRepository();
                this.reviewRepo = new EFReviewRepository();
            }
            else
            {
                this.productRepo = repo;
                this.reviewRepo = revRepo;
            }
        }

        public IActionResult Index()
        {
            var data = productRepo.Products.Include(x=>x.Reviews).ToList();
            return View(data);
        }

        public IActionResult Details(int id)
        {
            Product thisProduct = productRepo.Products.FirstOrDefault(p => p.ProductId == id);
            thisProduct.Reviews = reviewRepo.Reviews.Where(x => x.ProductId == id).ToList();
            return View(thisProduct);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            productRepo.Save(product);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            Product thisProduct = productRepo.Products.FirstOrDefault(p => p.ProductId == id);
            return View(thisProduct);
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            productRepo.Edit(product);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            Product thisProduct = productRepo.Products.FirstOrDefault(p => p.ProductId == id);
            return View(thisProduct);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            Product thisProduct = productRepo.Products.FirstOrDefault(x => x.ProductId == id);
            productRepo.Remove(thisProduct);
            List<Review> thisProductReviews = reviewRepo.Reviews.Include(y => y.ProductId == id).ToList();
            for(int j = 0; j < thisProductReviews.Count; j++)
            {
                reviewRepo.Remove(thisProductReviews[j]);
            }
            return RedirectToAction("Index");
        }

        public IActionResult DeleteAll()
        {
            return View();
        }

        [HttpPost, ActionName("DeleteAll")]
        public IActionResult DeleteAllConfirmed()
        {
            IEnumerable<Product> allProducts = productRepo.Products;
            IEnumerable<Review> allReviews = reviewRepo.Reviews;
            foreach(var product in allProducts)
            {
                productRepo.Remove(product);
            }
            foreach(var review in allReviews)
            {
                reviewRepo.Remove(review);
            }
            return RedirectToAction("Index");
        }
    }
}
