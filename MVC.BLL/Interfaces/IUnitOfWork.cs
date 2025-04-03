using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.BLL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        public IDapartmentRepository dapartmentRepository { get; set;  }

        public IEmployeeRepository employeeRepository { get; set; }


        Task<int> CompleteAsync(); // this method will save the changes to the database

       // void Dispose(); // this method will dispose the unit of work
    }
}
