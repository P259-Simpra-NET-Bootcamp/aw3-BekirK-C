using Entities.Concrete;
using Entities.Models.Requests;
using Entities.Models.Responses;

namespace Business.Abstract;

public interface IProductService
{
    List<ProductResponse> GetAll();
    ProductResponse GetById(int id);
    void Add(ProductRequest productRequest);
    void Update(ProductRequest productRequest);
    void Delete(int id);
}
