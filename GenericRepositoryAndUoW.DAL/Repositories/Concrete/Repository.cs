using GenericRepositoryAndUoW.DAL.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace GenericRepositoryAndUoW.DAL.Repositories.Concrete
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected DbContext dbContext;

        public DbSet<TEntity> Table { get; set; }

        public Repository(DbContext dbContext)
        {
            this.dbContext = dbContext;
            this.Table = dbContext.Set<TEntity>();
        }
        
        public void Add(TEntity entity)
        {
            Table.Add(entity);
        }

        public void AddRange(IQueryable<TEntity> entities)
        {
            Table.AddRange(entities);
        }

        public void Update(TEntity entity)
        {
            Table.Update(entity);
        }

        public void Delete(int id)
        {
            Table.Remove(GetById(id));
        }

        public void DeleteRange(IQueryable<TEntity> entities)
        {
            Table.RemoveRange(entities);
        }

        public IQueryable<TEntity> GetAll()
        {
            return Table;
        }

        public TEntity GetById(int id)
        {
            return Table.Find(id);
        }

        public IQueryable<TEntity> OrderBy<TKey>(Expression<Func<TEntity, TKey>> orderBy, bool isDesc)
        {
            if (isDesc)
                return Table.OrderByDescending(orderBy);
            return Table.OrderBy(orderBy);
        }

        public IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> where)
        {
            return Table.Where(where);
        }
    }
}
