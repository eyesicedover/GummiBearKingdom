using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GummiBearKingdom.Models;

namespace GummiBearKingdom.Models
{
    [Table("Products")]
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public double Cost { get; set; }
        public string Description { get; set; }

        public virtual List<Review> Reviews { get; set; }

        public Product()
        {

        }

        public Product(string name, string description, double cost)
        {
            Name = name;
            Description = description;
            Cost = cost;
        }

        public override bool Equals(System.Object otherItem)
        {
            if (!(otherItem is Product))
            {
                return false;
            }
            else
            {
                Product newItem = (Product)otherItem;
                return this.ProductId.Equals(newItem.ProductId);
            }
        }

        public override int GetHashCode()
        {
            return this.ProductId.GetHashCode();
        }
    }
}
