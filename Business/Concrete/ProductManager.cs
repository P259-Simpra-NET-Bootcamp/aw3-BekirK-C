using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class ProductManager : IProductService
{
    private readonly IProductDal _productDal;

    public ProductManager(IProductDal poductDal)
    {
        _productDal = poductDal;
    }

    public void Add(Product product)
    {
        _productDal.Add(product);
    }

    public void Delete(Product product)
    {
        _productDal.Delete(product);
    }

    public List<Product> GetAll()
    {
        return _productDal.GetList();
    }

    public Product GetById(int id)
    {
        return _productDal.Get(p => p.Id == id);
    }

    public void Update(Product product)
    {
        throw new NotImplementedException();
    }
}

