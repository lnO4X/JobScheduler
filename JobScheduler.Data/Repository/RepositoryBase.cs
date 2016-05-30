using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace JobScheduler.Data.Repository
{
    public abstract class RepositoryBase<TEntity> : IRepository<TEntity> where TEntity
  : class, new()
    {
        public DbContext context; //提供IOC注入方式接口
        public RepositoryBase(SchedulerContext context)
        {
            this.context = context;
        } //测试用
        public RepositoryBase()
        {
            this.context = new SchedulerContext();
        }
        #region IRepository<T> 成员
        public TEntity Create()
        {
            return context.Set<TEntity>().Create();
        }
        public TEntity Update(TEntity entity)
        {
            //执行验证业务
            //context.Entry<T>(entity).GetValidationResult(); 
            if (context.Entry<TEntity>(entity).State == EntityState.Modified)
                context.SaveChanges();
            return entity;
        }
        public TEntity Insert(TEntity entity)
        {
            context.Set<TEntity>().Add(entity);
            context.SaveChanges(); return entity;
        }
        public void Delete(TEntity entity)
        {
            context.Set<TEntity>().Remove(entity);
            context.SaveChanges();
        }

        public List<TEntity> FindAll()
        {
            return context.Set<TEntity>().ToList();
        }

        public TEntity FindOne(Expression<Func<TEntity, Boolean>> expression)
        {
            return context.Set<TEntity>().Where(expression).FirstOrDefault();

        }
        public List<TEntity> FindList(Expression<Func<TEntity, Boolean>> expression)
        {
            return context.Set<TEntity>().Where(expression).ToList();
        }
        #endregion
    }
}
