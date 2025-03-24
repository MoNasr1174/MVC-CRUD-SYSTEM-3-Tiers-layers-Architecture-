using MVC.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.BLL.Interfaces
{
    internal interface IDapartmentRepository
    {
        IEnumerable<Department> GetAll(); // Get All Departments

        Department GetById(int id); // Get Department By Id

        int Add(Department Entity); // Add Department

        int Update(Department Entity); // Update Department


        int Delete(Department Entity); // Delete Department

    }
}
