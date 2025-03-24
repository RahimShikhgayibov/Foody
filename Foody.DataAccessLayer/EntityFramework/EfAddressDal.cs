using Foody.DataAccessLayer.Abstract;
using Foody.DataAccessLayer.Context;
using Foody.DataAccessLayer.Repositories;
using Foody.EntityLayer.Concrete;

namespace Foody.DataAccessLayer.EntityFramework;

public class EfAddressDal : GenericRepository<Address>, IAddressDal
{
    public EfAddressDal(FoodyDbContext context) : base(context)
    {
    }
}
