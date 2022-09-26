﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PortalStore.CoreLayer.IntRepository
{
    public interface IRepository<T> where T : class
    {
        Task<T> GetByIdAsync(int id); 
        Task<IEnumerable<T>> GetAllAsync(); 
        Task<IEnumerable<T>> Where(Expression<Func<T, bool>> predicate);  
        Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate);  
        Task<T> SingleOrDefaultAsync(Expression<Func<T, bool>> predicate);
        Task<IQueryable<T>> QListAsync();        
        Task AddAsync(T entity); 
        Task AddRangeAsync(IEnumerable<T> entities);
        T Update(T entity);       
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);  
        Task DeleteAsync(T entity);
        Task DeleteRangeAsync(IEnumerable<T> entities); 

    }
}
