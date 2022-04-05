using Core.Abstract;
using DataAccess.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EntityRepository<TEntity> : IEntityRepository<TEntity> where TEntity : class, IEntity
    {
        private readonly DbContext db;
        public EntityRepository( DbContext _db)
        {
            db = _db;
        }
        public async Task<bool> AsyncAdd(TEntity entity)
        {
            await db.Set<TEntity>().AddAsync(entity);
            return true;
        }

        public async Task<bool> AsyncDelete(int Id)
        {
            await Task.Run(() => { db.Set<TEntity>().Remove(GetById(Id).Result); });
            return true;
        }

        public async Task<bool> AsyncUpdate(TEntity entity)
        {
            await Task.Run(() => db.Set<TEntity>().Update(entity));
            return true;
        }

        public async Task<IList<TEntity>> GetAllData(Expression<Func<TEntity, bool>> Where = null, params Expression<Func<TEntity, object>>[] include)
        {
            IQueryable<TEntity> query;
            if (Where != null)
            {
                query = db.Set<TEntity>().Where(Where);
            }
            else
            {
                query = db.Set<TEntity>();
            }
            if (include.Any())

            {
                foreach (var item in include)
                {
                    query = query.Include(item);
                } 
            }
           return await query.ToListAsync();
        }

        public async Task<TEntity> GetById(int Id, params Expression<Func<TEntity, object>>[] include)
        {
            return await db.Set<TEntity>().FindAsync(Id);
        }

        public async Task<bool> VarmiYokmi(Expression<Func<TEntity, bool>> where)
        {
            return await db.Set<TEntity>().AnyAsync(where);
        }
    }
}
