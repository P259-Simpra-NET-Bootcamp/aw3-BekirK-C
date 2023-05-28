using AutoMapper;
using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;
using Entities.Models.Requests;
using Entities.Models.Responses;

namespace Business.Concrete;

public class CategoryManager : ICategoryService
{
    private readonly ICategoryDal _categoryDal;
    private readonly IMapper _mapper;

    public CategoryManager(ICategoryDal categoryDal, IMapper mapper)
    {
        _categoryDal = categoryDal;
        _mapper = mapper;
    }

    public void Add(CategoryRequest categoryRequest)
    {
        var mapped = _mapper.Map<CategoryRequest, Category>(categoryRequest);
        _categoryDal.Add(mapped);
    }

    public void Delete(int id)
    {
        var entity = _categoryDal.Get(p => p.Id == id);
        _categoryDal.Delete(entity);
    }

    public List<CategoryResponse> GetAll()
    {
        var list = _categoryDal.GetList();
        var mapped = _mapper.Map<List<Category>, List<CategoryResponse>>(list);
        return mapped;
    }

    public List<CategoryResponse> GetAllWithInclude()
    {
        var list = _categoryDal.GetListWithInclude("Products");
        var mapped = _mapper.Map<List<Category>, List<CategoryResponse>>(list);
        return mapped;
    }

    public CategoryResponse GetById(int id)
    {
        var entity = _categoryDal.Get(p => p.Id == id);
        var mapped = _mapper.Map<Category, CategoryResponse>(entity);
        return mapped;
    }

    public void Update(CategoryRequest categoryRequest)
    {
        var mapped = _mapper.Map<CategoryRequest, Category>(categoryRequest);
        _categoryDal.Update(mapped);
    }
}
