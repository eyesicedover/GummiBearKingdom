using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GummiBearKingdom.Models
{
    public class IReviewRepository
    {
        IQueryable<Review> Reviews { get; }
        Review Save(Review review);
        Review Edit(Review review);
        void Remove(Review review);
    }
}
