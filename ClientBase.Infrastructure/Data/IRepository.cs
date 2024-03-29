﻿using ClientBase.Infrastructure.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientBase.Infrastructure.Data
{
    public interface IRepository<T> where T : class, IEntityBase<long>
    {
        T Get(long id);
        void Add(T entity);
        void AddRange(IEnumerable<T> entities);
        void Update(T entity);
        void Delete(long id);
        IQueryable<T> Query();
        void SaveChanges();
    }
}
