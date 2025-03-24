using Foody.DataAccessLayer.Abstract;
using Foody.DataAccessLayer.Context;
using Foody.DataAccessLayer.Repositories;
using Foody.EntityLayer.Concrete;

namespace Foody.DataAccessLayer.EntityFramework;

public class EfSliderDal : GenericRepository<Slider>, ISliderDal
{
    public EfSliderDal(FoodyDbContext context) : base(context)
    {
    }
}
