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
        public async Task AddAsync(T Entity)
         =>  await _dBContext.Set<T>().AddAsync(Entity);
        

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            if(typeof(T) == typeof(Employee))
            {
                return  (IEnumerable<T>) await _dBContext.Employees.Include(E => E.Department).AsNoTracking().ToListAsync() ;
            }
            return await _dBContext.Set<T>().AsNoTracking().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
            => await _dBContext.Set<T>().FindAsync(id);





        public void Update(T Entity)
           => _dBContext.Set<T>().Update(Entity);
         
        public void Delete(T Entity)
        => _dBContext.Set<T>().Remove(Entity);



    }
}

