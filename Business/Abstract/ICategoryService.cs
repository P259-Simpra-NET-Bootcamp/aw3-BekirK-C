using Entities.Concrete;
using Entities.Models.Requests;
using Entities.Models.Responses;

namespace Business.Abstract;

public interface ICategoryService
{
    List<CategoryResponse> GetAll();
    List<CategoryResponse> GetAllWithInclude();
    CategoryResponse GetById(int id);
    void Add(CategoryRequest category);
    void Update(CategoryRequest category);
    void Delete(int id);
}
