using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace HR_Management.Application.presistence.Contracts
{
    public interface IGenericRepository<T> where T : class
    {
        public IQueryable<T> Read();

        public IQueryable<T> Read(Expression<Func<T, bool>> predicate);

        public T Read(int id);
        public Task<T> ReadAsync(int id);


        public void Create(T entity);
        public Task CreateAsync(T entity);


        public bool Update(T entity);
        public bool Delete(T entity);
        public bool Delete(int id);
    }
}
