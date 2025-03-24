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
    public class DepartmentRepository : IDapartmentRepository
    {
        private readonly AppDBContext _dbContext;

        public DepartmentRepository(AppDBContext dbContext) // ask clr to inject the instance of AppDBContext
        {
            _dbContext = dbContext;
        }
        public int Add(Department Entity)
        {
            _dbContext.Departments.Add(Entity);

            return _dbContext.SaveChanges();
        }

        public int Delete(Department Entity)
        {
            _dbContext.Departments.Remove(Entity);
            return _dbContext.SaveChanges();
        }

        public IEnumerable<Department> GetAll()
          =>  _dbContext.Departments.AsNoTracking().ToList();
        

        public Department GetById(int id)
        {
          
            return _dbContext.Departments.Find(id);

            // Find() method is used to find an entity with the given primary key values.
            // If the entity is being tracked, then it is returned immediately without making a
            // request to the database. Otherwise, a query is made to the database for an entity with t
            // he given primary key values and this entity, if found, is attached to the context and returned.
            // If no entity is found, then null is returned.

            
        }

        public int Update(Department Entity)
        {
            _dbContext.Departments.Update(Entity);
            return _dbContext.SaveChanges();
        }
    }
}
