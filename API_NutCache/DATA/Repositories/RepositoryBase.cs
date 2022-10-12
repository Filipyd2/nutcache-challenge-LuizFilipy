using DATA.Context;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;
using DATA.Interfaces;

namespace DATA.Repositories
{
    public class RepositoryBase : IRepositoryBase
    {

        readonly DbSet<Employee> _DbSet;
        public Api_NutcacheEntities dbContext;

        public RepositoryBase()
        {
            dbContext = new Api_NutcacheEntities();
            _DbSet = dbContext.Employee;
        }

        public int Delete(Employee objeto)
        {
            var retorno = _DbSet.Remove(objeto);
            dbContext.SaveChanges();
            dbContext.Dispose();
            return retorno.IdEmployee;
        }

        public Employee Edit(Employee objeto)
        {
            var Update = _DbSet.Find(objeto.IdEmployee);                  
            dbContext.Entry(Update).State = EntityState.Modified;
            dbContext.SaveChanges();
            dbContext.Dispose();
            return Update;
        }

        public Employee Insert(Employee objeto)
        {
            var retorno = _DbSet.Add(objeto);
            dbContext.SaveChanges();
            dbContext.Dispose();
            return retorno;
        }

        public List<Employee> ListAll()
        {
            var retorno = _DbSet.AsQueryable();
            dbContext.SaveChanges();
            dbContext.Dispose();
            return retorno.ToList<Employee>();
        }


        public Employee Select(int Id)
        {
            var retorno = _DbSet.Find(Id);
            dbContext.SaveChanges();
            dbContext.Dispose();
            return retorno;
        }
    }
}
