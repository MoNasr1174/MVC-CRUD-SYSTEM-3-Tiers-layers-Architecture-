using Microsoft.EntityFrameworkCore;
using MVC.BLL.Interfaces;
using MVC.BLL.Repositories;
using MVC.DAL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.BLL
{
    public class UnitOfWork : IUnitOfWork 
    {
        private readonly AppDBContext _dbContext;
        public IDapartmentRepository dapartmentRepository { get; set; }
        public IEmployeeRepository employeeRepository { get; set; }
        public UnitOfWork(AppDBContext dbContext )
        {
            _dbContext = dbContext;
            dapartmentRepository = new DepartmentRepository(_dbContext);
            employeeRepository = new EmployeeRepository(_dbContext);
        }
       

        public async Task<int> CompleteAsync()
        {
           return  await _dbContext.SaveChangesAsync(); 
        }

        public void Dispose() 
        {
            _dbContext.Dispose();
        }
    }
}
