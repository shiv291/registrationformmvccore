using Microsoft.EntityFrameworkCore;
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace TestForm.Models
{
    public class DbRepository<T> : IDbRepository<T> where T : class
    {
        RegistrationContext dbContext;
        public DbRepository()
        {
            dbContext = new RegistrationContext();
        }

        public IQueryable<T> Filter(Expression<Func<T, bool>> expression)
        {
            return this.dbContext.Set<T>().Where(expression).AsNoTracking();
        }

        public IQueryable<T> FindAll()
        {
            return this.dbContext.Set<T>().AsNoTracking();
        }

        public T Save(T _entity)
        {
            dbContext.Set<T>().Add(_entity);
            dbContext.SaveChanges();
            return _entity;
        }

        public void Update(T entity)
        {
            dbContext.Set<T>().Update(entity);
            dbContext.SaveChanges();
        }

        public void Delete(T entity)
        {
            dbContext.Set<T>().Remove(entity);
            dbContext.SaveChanges();
        }

        // Flag: Has Dispose already been called?
        bool disposed = false;
        // Instantiate a SafeHandle instance.
        SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);
       
    }

    public interface IDbRepository<T>
    {
        T Save(T _entity);
        IQueryable<T> FindAll();
        IQueryable<T> Filter(Expression<Func<T, bool>> expression);
        void Update(T entity);
        void Delete(T entity);
    }
}
