using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Std.Core
{
    public interface IRepository<T, TPrimaryKey> where T : class, IEntity<TPrimaryKey>
    {
        DbSet<T> Table { get; }
        TPrimaryKey Add(T entity);
        void Update(T entity);
        void Delete(T entity);

        T GetById(TPrimaryKey id);

        IQueryable<T> All();
        IQueryable<T> Where(Expression<Func<T, bool>> where);
    }
}
