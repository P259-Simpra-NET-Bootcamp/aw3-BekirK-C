using Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DataAccess.Repository;

public class GenericRepository<TEntity, TContext> : IGenericRepository<TEntity> where TEntity : class, IEntity, new() where TContext : DbContext, new()
{
    public void Add(TEntity entity)
    {
        using (var context = new TContext())
        {
            var addedEntity = context.Entry(entity);
            addedEntity.State = EntityState.Added;
            context.SaveChanges();
        }
    }

    public void Delete(TEntity entity)
    {
        using (var context = new TContext())
        {
            var deletedEntity = context.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
            context.SaveChanges();
        }
    }

    public TEntity Get(Expression<Func<TEntity, bool>> filter)
    {
        using (var context = new TContext())
        {
            return context.Set<TEntity>().SingleOrDefault(filter);
        }
    }

    public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
    {
        using (var context = new TContext())
        {
            return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();
        }
    }

    public List<TEntity> GetListWithInclude(params string[] includes)
    {
        using (var context = new TContext())
        {
            var query = context.Set<TEntity>().AsQueryable();
            query = includes.Aggregate(query, (current, inc) => current.Include(inc));
            return query.ToList();
        }
    }

    public void Update(TEntity entity)
    {
        using (var context = new TContext())
        {
            var updatedEntity = context.Entry(entity);
            updatedEntity.State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}