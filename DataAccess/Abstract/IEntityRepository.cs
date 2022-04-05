using Core.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<TEntity> where TEntity: class,IEntity
    {

        public Task<TEntity> GetById(int Id, params Expression<Func<TEntity, object>>[] includeTable);
        public Task<IList<TEntity>> GetAllData(Expression<Func<TEntity, bool>> Where = null, params Expression<Func<TEntity, object>>[] include);
        public Task<bool> AsyncAdd(TEntity entity);
        public Task<bool> AsyncUpdate(TEntity entity);
        public Task<bool> AsyncDelete(int Id);

        Task<bool> VarmiYokmi(Expression<Func<TEntity, bool>> where);




    }
}
