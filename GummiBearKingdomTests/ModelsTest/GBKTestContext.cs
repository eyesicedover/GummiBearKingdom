using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace GummiBearKingdom.Models
{
    public class GBKTestContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Review> Reviews { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(@"Server=localhost;Port=8889;database=gbktest;uid=root;pwd=root;");
        }         
    }
}
