using DataAccess.Abstract;
using DataAccess.Context;
using DataAccess.Repository;
using Entities.Concrete;

namespace DataAccess.Concrete;

public class CategoryDal : GenericRepository<Category, SimpraDbContext>, ICategoryDal
{
}
