using Entities.Abstract;
using Entities.Base;

namespace Entities.Concrete;

public class Category : BaseEntity, IEntity
{
    public string Name { get; set; }
    public int Order { get; set; }
    public List<Product> Products { get; set; }
}
