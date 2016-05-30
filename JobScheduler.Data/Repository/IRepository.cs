using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace JobScheduler.Data.Repository
{
    public interface IRepository<T> where T
        : class, new()
    {
        T Create();
        T Update(T entity);
        T Insert(T entity);
        void Delete(T entity);
        List<T> FindAll();
        T FindOne(Expression<Func<T, bool>> expression);
        List<T> FindList(Expression<Func<T, bool>> expression);
    }
}
