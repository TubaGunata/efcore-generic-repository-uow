using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace GenericRepositoryAndUoW.DAL.Repositories.Abstract
{
    public interface IRepository<TEntity> where TEntity : class
    {
        DbSet<TEntity> Table { get; }
        void Add(TEntity entity);
        void AddRange(IQueryable<TEntity> entities);
        void Update(TEntity entity);
        void Delete(int id);
        void DeleteRange(IQueryable<TEntity> entities);


        TEntity GetById(int id);
        IQueryable<TEntity> GetAll();
        IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> where);
        IQueryable<TEntity> OrderBy<TKey>(Expression<Func<TEntity, TKey>> orderBy, bool isDesc);

    }
}
