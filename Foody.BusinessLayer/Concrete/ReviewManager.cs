﻿using Foody.BusinessLayer.Abstract;
using Foody.DataAccessLayer.Abstract;
using Foody.EntityLayer.Concrete;

namespace Foody.BusinessLayer.Concrete;

public class ReviewManager : IReviewService
{
    private readonly IReviewDal _reviewDal;

    public ReviewManager(IReviewDal reviewDal)
    {
        _reviewDal = reviewDal;
    }

    public void TDelete(int id)
    {
        _reviewDal.Delete(id);
    }

    public List<Review> TGetAll()
    {
        return _reviewDal.GetAll();
    }

    public Review TGetById(int id)
    {
        return _reviewDal.GetById(id);
    }

    public void TInsert(Review entity)
    {
        _reviewDal.Insert(entity);
    }

    public void TUpdate(Review entity)
    {
        _reviewDal.Update(entity);
    }
}
