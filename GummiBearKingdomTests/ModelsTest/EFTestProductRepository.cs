using GummiBearKingdom.Controllers;
using GummiBearKingdom.Models;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GummiBearKingdom.Models
{
    public class EFTestProductRepository : IProductRepository
    {
        GBKTestContext db;

        public IQueryable<Product> Products
        { get { return db.Products; } }

        public EFTestProductRepository()
        {
            db = new GBKTestContext();
        }
        public EFTestProductRepository(GBKTestContext thisDb)
        {
            db = thisDb;
        }

        public Product Save(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
            return product;
        }

        public Product Edit(Product product)
        {
            db.Entry(product).State = EntityState.Modified;
            db.SaveChanges();
            return product;
        }

        public void Remove(Product product)
        {
            db.Products.Remove(product);
            db.SaveChanges();
        }
    }
}
