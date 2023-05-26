using Entities.Abstract;
using Entities.Base;

namespace Entities.Concrete;

public class Product : BaseEntity, IEntity
{
    public int CategoryId { get; set; }
    public string Name { get; set; }
    public string Url { get; set; }
    public string Tag { get; set; }
    public Category Category { get; set; }
}
