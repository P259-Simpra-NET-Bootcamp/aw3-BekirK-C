namespace Entities.Models.Responses;

public class CategoryResponse
{
    public string Name { get; set; }
    public int Order { get; set; }
    public List<ProductResponse> Products { get; set; }
}
