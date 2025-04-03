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
        public IDapartmentRepository _dapartmentRepository;
        public IEmployeeRepository _employeeRepository;
        public UnitOfWork(AppDBContext dbContext )
        {
            _dbContext = dbContext;
            _dapartmentRepository = new DepartmentRepository(_dbContext);
            _employeeRepository = new EmployeeRepository(_dbContext);
        }
        public IDapartmentRepository dapartmentRepository { get; set; }
        public IEmployeeRepository employeeRepository { get ; set; }

        public int Complete()
        {
           return  _dbContext.SaveChanges(); 
        }

        public void Dispose() 
        {
            _dbContext.Dispose();
        }
    }
}
