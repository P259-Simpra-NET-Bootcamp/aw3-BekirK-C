using AutoMapper;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Models.Requests;
using Entities.Models.Responses;

namespace Business.Concrete;

public class ProductManager : IProductService
{
    private readonly IProductDal _productDal;
    private readonly IMapper _mapper;

    public ProductManager(IProductDal poductDal, IMapper mapper)
    {
        _productDal = poductDal;
        _mapper = mapper;
    }

    public void Add(ProductRequest productRequest)
    {
        var mapped = _mapper.Map<ProductRequest, Product>(productRequest);
        _productDal.Add(mapped);
    }

    public void Delete(int id)
    {
        var entity = _productDal.Get(p => p.Id == id);
        _productDal.Delete(entity);
    }

    public List<ProductResponse> GetAll()
    {
        var list = _productDal.GetList();
        var mapped = _mapper.Map<List<Product>, List<ProductResponse>>(list);
        return mapped;
    }

    public List<ProductResponse> GetAllWithInclude()
    {
        var list = _productDal.GetListWithInclude("Category");
        var mapped = _mapper.Map<List<Product>, List<ProductResponse>>(list);
        return mapped;
    }

    public ProductResponse GetById(int id)
    {
        var entity = _productDal.Get(p => p.Id == id);
        var mapped = _mapper.Map<Product, ProductResponse>(entity);
        return mapped;
    }

    public void Update(ProductRequest productRequest)
    {
        var mapped = _mapper.Map<ProductRequest, Product>(productRequest);
        _productDal.Update(mapped);
    }
}

