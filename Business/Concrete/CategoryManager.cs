﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class CategoryManager : ICategoryService
{
    private readonly ICategoryDal _categoryDal;

    public CategoryManager(ICategoryDal categoryDal)
    {
        _categoryDal = categoryDal;
    }

    public void Add(Category category)
    {
        _categoryDal.Add(category);
    }

    public void Delete(Category category)
    {
        _categoryDal.Delete(category);
    }

    public List<Category> GetAll()
    {
        return _categoryDal.GetList();
    }

    public Category GetById(int id)
    {
        return _categoryDal.Get(c => c.Id == id);
    }

    public void Update(Category category)
    {
        _categoryDal.Update(category);
    }
}
