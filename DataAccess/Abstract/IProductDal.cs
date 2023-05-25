﻿using DataAccess.Repository;
using Entities.Concrete;

namespace DataAccess.Abstract;

public interface IProductDal : IGenericRepository<Product>
{
}
