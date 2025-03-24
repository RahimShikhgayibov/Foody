using Foody.DataAccessLayer.Abstract;
using Foody.DataAccessLayer.Context;
using Foody.DataAccessLayer.Repositories;
using Foody.EntityLayer.Concrete;

namespace Foody.DataAccessLayer.EntityFramework;

public class EfReviewDal : GenericRepository<Review>, IReviewDal
{
    public EfReviewDal(FoodyDbContext context) : base(context)
    {
    }
}
