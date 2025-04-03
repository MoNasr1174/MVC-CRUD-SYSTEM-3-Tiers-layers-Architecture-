using Microsoft.AspNetCore.Mvc;
using MVC.BLL.Interfaces;
using MVC.DAL.Models;
using System;

namespace MVC_.PL.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IUnitOfWork _UnitOfWork;

        // private readonly IDapartmentRepository _dapartmentRepository; // readonly field for IDapartmentRepository

        public DepartmentController(IUnitOfWork unitOfWork) 
        {
            _UnitOfWork = unitOfWork;
          //  _dapartmentRepository = dapartmentRepository;
        }
        public IActionResult Index()
        {
            var departments = _UnitOfWork.dapartmentRepository.GetAll(); // Get All Departments

            return View(departments);
        }

        [HttpGet]
 

        public IActionResult Create() // that will return the view of create
        {
            return View();
        }


        [HttpPost]
     


        public IActionResult Create(Department department) // that will add the department to the database
        {
            if (ModelState.IsValid)
            {
                var count = _UnitOfWork.dapartmentRepository.Add(department);
                _UnitOfWork.Complete();
                if (count > 0)
                    return RedirectToAction("Index");
            }
            return View(department);
        }


        [HttpGet]
       

        public IActionResult Details(int? id , string ViewName = "Details") // that will return the view of update
        {
           if (!id.HasValue)
            {
                return BadRequest();
            }
            var department = _UnitOfWork.dapartmentRepository.GetById(id.Value);


            if (department == null)
            {
                return NotFound();
            }
            return View(ViewName, department);
        }


        [HttpGet]

        public IActionResult Edit(int? id) // that will return the view of update
        {
            return Details(id , "Edit");
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit([FromRoute] int id, Department department) // that will update the department in the database

        {
            if (id != department.Id)
            {
                return BadRequest();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    var count = _UnitOfWork.dapartmentRepository.Update(department);
                    _UnitOfWork.Complete();
                    if (count > 0)
                        return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError(string.Empty, ex.Message);
                }
              


            }
            return View(department);

        }

        [HttpGet]

        public IActionResult Delete(int? id) // that will return the view of update
        {
            return Details(id, "Delete");
        }




        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete([FromRoute] int id, Department department) // that will update the department in the database

        {
            if (id != department.Id)
            {
                return BadRequest();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    var count = _UnitOfWork.dapartmentRepository.Delete(department);
                    _UnitOfWork.Complete();
                    if (count > 0)
                        return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError(string.Empty, ex.Message);
                }



            }
            return View(department);

        }



    }
}

