using Microsoft.AspNetCore.Mvc;
using MVC.BLL.Interfaces;
using MVC.DAL.Models;
using System;

namespace MVC_.PL.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository; // readonly field for IDapartmentRepository

        public EmployeeController(IEmployeeRepository employeeRepository) // ask Clr to create an object from class implements IDapartmentRepository
        {
            _employeeRepository = employeeRepository;
        }
        public IActionResult Index()
        {
            var Employees = _employeeRepository.GetAll(); // Get All Employees
            return View(Employees);
        }

        [HttpGet]


        public IActionResult Create() // that will return the view of create
        {
            return View();
        }


        [HttpPost]



        public IActionResult Create(Employee Employee) // that will add the Employee to the database
        {
            if (ModelState.IsValid)
            {
                var count = _employeeRepository.Add(Employee);
                if (count > 0)
                    return RedirectToAction("Index");
            }
            return View(Employee);
        }


        [HttpGet]


        public IActionResult Details(int? id, string ViewName = "Details") // that will return the view of update
        {
            if (!id.HasValue)
            {
                return BadRequest();
            }
            var Employee = _employeeRepository.GetById(id.Value);

            if (Employee == null)
            {
                return NotFound();
            }
            return View(ViewName, Employee);
        }


        [HttpGet]

        public IActionResult Edit(int? id) // that will return the view of update
        {
            return Details(id, "Edit");
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit([FromRoute] int id, Employee Employee) // that will update the Employee in the database

        {
            if (id != Employee.Id)
            {
                return BadRequest();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    var count = _employeeRepository.Update(Employee);
                    if (count > 0)
                        return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError(string.Empty, ex.Message);
                }



            }
            return View(Employee);

        }

        [HttpGet]

        public IActionResult Delete(int? id) // that will return the view of update
        {
            return Details(id, "Delete");
        }




        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete([FromRoute] int id, Employee Employee) // that will update the Employee in the database

        {
            if (id != Employee.Id)
            {
                return BadRequest();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    var count = _employeeRepository.Delete(Employee);
                    if (count > 0)
                        return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError(string.Empty, ex.Message);
                }



            }
            return View(Employee);

        }

    }
}
