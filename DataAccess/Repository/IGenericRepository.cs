using Entities.Abstract;
using System.Linq.Expressions;

namespace DataAccess.Repository;

public interface IGenericRepository<T> where T : class, IEntity
{
    T Get(Expression<Func<T, bool>> filter);
    List<T> GetList(Expression<Func<T, bool>> filter = null);
    List<T> GetListWithInclude(params string[] includes);
    void Add(T entity);
    void Update(T entity);
    void Delete(T entity);
}
