﻿using Foody.DataAccessLayer.Abstract;
using Foody.DataAccessLayer.Context;
using Foody.DataAccessLayer.Repositories;
using Foody.EntityLayer.Concrete;

namespace Foody.DataAccessLayer.EntityFramework;

public class EfSocialMediaDal : GenericRepository<SocialMedia>, ISocialMediaDal
{
    public EfSocialMediaDal(FoodyDbContext context) : base(context)
    {
    }
}
