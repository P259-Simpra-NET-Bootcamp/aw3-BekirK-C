using Entities.Concrete;

namespace Entities.Models.Responses;

public class ProductResponse
{
    public int CategoryId { get; set; }
    public string Name { get; set; }
    public string Url { get; set; }
    public string Tag { get; set; }
    //public Category Category { get; set; }
}
