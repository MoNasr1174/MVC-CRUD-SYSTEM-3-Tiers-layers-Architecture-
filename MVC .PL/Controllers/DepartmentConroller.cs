using Microsoft.AspNetCore.Mvc;
using MVC.BLL.Interfaces;
using MVC.DAL.Models;
using System;
using System.Threading.Tasks;

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
        public async Task<IActionResult> Index()
        {
            var departments = await _UnitOfWork.dapartmentRepository.GetAllAsync(); // Get All Departments

            return View(departments);
        }

        [HttpGet]
 

        public IActionResult Create() // that will return the view of create
        {
            return View();
        }


        [HttpPost]
     


        public async Task<IActionResult> Create(Department department) // that will add the department to the database
        {
            if (ModelState.IsValid)
            {
                 await _UnitOfWork.dapartmentRepository.AddAsync(department);
                var count = await _UnitOfWork.CompleteAsync();
                if (count > 0)
                    return RedirectToAction("Index");
            }
            return View(department);
        }


        [HttpGet]
       

        public async Task<IActionResult> Details(int? id , string ViewName = "Details") // that will return the view of update
        {
           if (!id.HasValue)
            {
                return BadRequest();
            }
            var department =  await _UnitOfWork.dapartmentRepository.GetByIdAsync(id.Value);


            if (department == null)
            {
                return NotFound();
            }
            return View(ViewName, department);
        }


        [HttpGet]

        public async Task<IActionResult> Edit(int? id) // that will return the view of update
        {
            return  await Details(id , "Edit");
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit([FromRoute] int id, Department department) // that will update the department in the database

        {
            if (id != department.Id)
            {
                return BadRequest();
            }
            if (ModelState.IsValid)
            {
                try
                {
                     _UnitOfWork.dapartmentRepository.Update(department);
                    var count = await _UnitOfWork.CompleteAsync();
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

        public  async Task<IActionResult> Delete(int? id) // that will return the view of update
        {
            return  await Details(id, "Delete");
        }




        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete([FromRoute] int id, Department department) // that will update the department in the database

        {
            if (id != department.Id)
            {
                return BadRequest();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    _UnitOfWork.dapartmentRepository.Delete(department);
                    var count = await _UnitOfWork.CompleteAsync();
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

