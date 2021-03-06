﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Store.DataAccess.Entities;

namespace Store.DataAccess.Repositories
{
    public interface IGenericRepository<TEntity> where TEntity : IEntity
    {
        TEntity Get(int id);
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> GetRange(int start, int count);
        IEnumerable<TEntity> GetRange(int start, int count, Expression<Func<TEntity, bool>> predicate);
        IEnumerable<TEntity> GetAllIncluding(params Expression<Func<TEntity, object>>[] propertySelectors);
        int Count();
        void Add(TEntity entity);
        void Remove(int id);
        void SaveChanges();
    }
}
