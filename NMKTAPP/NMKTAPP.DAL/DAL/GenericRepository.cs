using Microsoft.EntityFrameworkCore;
using NMKTAPP.DAL.Interface;
using NMKTAPP.DatabaseContext.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMKTAPP.DAL.DAL
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        ProjectDbContext Db;
        public GenericRepository(DbContext db)
        {
            Db = (ProjectDbContext)db;
        }
        public void Add(T entity)
        {
            Db.Set<T>().Add(entity);
        }

        public void AddRange(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> Find(System.Linq.Expressions.Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(T entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }
    }

    
}
