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
    public class EmployeeRepository : GenericRepository<Employee> , IEmployeeRepository
    {
        public EmployeeRepository(AppDBContext dbContext) : base(dbContext) 
        {
        }

        public IQueryable<Employee> GetEmployeeByName(string name)
        {
          return _dBContext.Employees.Where(E => E.Name.ToLower().Contains( name.ToLower()));
        }
    }
}
