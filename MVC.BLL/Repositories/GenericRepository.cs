using Microsoft.EntityFrameworkCore;
using MVC.BLL.Interfaces;
using MVC.DAL.Data;
using MVC.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.BLL.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private protected readonly AppDBContext _dBContext;

        public GenericRepository(AppDBContext dBContext)
        {
            _dBContext = dBContext;
        }
        public int Add(T Entity)
        {
            _dBContext.Set<T>().Add(Entity);
            var Count = _dBContext.SaveChanges();
            return Count;

        }

        public IEnumerable<T> GetAll()
        {
            return _dBContext.Set<T>().AsNoTracking().ToList();
        }

        public T GetById(int id)
        {
            return _dBContext.Set<T>().Find(id);
        }


        public int Update(T Entity)
        {
            _dBContext.Set<T>().Update(Entity);
            var Count = _dBContext.SaveChanges();
            return Count;
        }
        public int Delete(T Entity)
        {
            _dBContext.Set<T>().Remove(Entity);
            var Count = _dBContext.SaveChanges();
            return Count;
        }

    }
}

