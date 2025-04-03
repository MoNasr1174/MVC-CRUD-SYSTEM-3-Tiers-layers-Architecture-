using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MVC.BLL.Interfaces;
using MVC.DAL.Models;
using MVC_.PL.ViewModels;
using System;
using System.Collections.Generic;

namespace MVC_.PL.Controllers
{
    public class EmployeeController : Controller
    {
        //  private readonly IEmployeeRepository _employeeRepository; // readonly field for IDapartmentRepository

        private readonly IMapper _mapper ;
        private readonly IUnitOfWork _unitOfWork; // readonly field for IUnitOfWork

        //  private readonly IDapartmentRepository _dapartmentRepository; // readonly field for IDapartmentRepository

        public EmployeeController(IMapper Mapper, IUnitOfWork unitOfWork) // ask Clr to create an object from class implements IDapartmentRepository
        {
           _mapper = Mapper;
            _unitOfWork = unitOfWork;
         
            //  _employeeRepository = employeeRepository;
            //_dapartmentRepository = dapartmentRepo;
        }
        public IActionResult Index(string searchInp)
        {
            IEnumerable<Employee> employees;
            if (string.IsNullOrEmpty(searchInp))
            {
                employees = _unitOfWork.employeeRepository.GetAll(); // Get All Employees
                
              
            }else
            {
               employees = _unitOfWork.employeeRepository.GetEmployeeByName(searchInp);
              
            }

            _unitOfWork.Complete();

            var mappedEpms = _mapper.Map<IEnumerable<Employee> , IEnumerable<EmployeeViewModel>>(employees);
            return View(mappedEpms);


        }

        [HttpGet]


        public IActionResult Create() // that will return the view of create
        {
            //ViewBag.Departments = _dapartmentRepository.GetAll();

            return View();
        }


        [HttpPost]



        public IActionResult Create(EmployeeViewModel EmployeeVM) // that will add the Employee to the database
        {
            if (ModelState.IsValid)
            {
                var mappedEmployee = _mapper.Map<EmployeeViewModel, Employee >(EmployeeVM);
                var count = _unitOfWork.employeeRepository.Add(mappedEmployee);
                _unitOfWork.Complete();
                if (count > 0)
                    return RedirectToAction("Index");
            }
            return View(EmployeeVM);
        }


        [HttpGet]


        public IActionResult Details(int? id, string ViewName = "Details") // that will return the view of update
        {
            if (!id.HasValue)
            {
                return BadRequest();
            }
            var Employee = _unitOfWork.employeeRepository.GetById(id.Value);



            var MappEmp = _mapper.Map<Employee, EmployeeViewModel>(Employee); 

            if (Employee == null)
            {
                return NotFound();
            }
            return View(ViewName, MappEmp);
        }


        [HttpGet]

        public IActionResult Edit(int? id) // that will return the view of update
        {
            //ViewBag.Departments = _dapartmentRepository.GetAll();

            return Details(id, "Edit");
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit([FromRoute] int id, EmployeeViewModel EmployeeVM) // that will update the Employee in the database

        {
            if (id != EmployeeVM.Id)
            {
                return BadRequest();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    var mappedEmployee = _mapper.Map<EmployeeViewModel, Employee>(EmployeeVM);
                    var count = _unitOfWork.employeeRepository.Update(mappedEmployee);
                    _unitOfWork.Complete();
                    if (count > 0)
                        return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError(string.Empty, ex.Message);
                }



            }
            return View(EmployeeVM);

        }

        [HttpGet]

        public IActionResult Delete(int? id) // that will return the view of update
        {
            return Details(id, "Delete");
        }




        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete([FromRoute] int id, EmployeeViewModel EmployeeVM) // that will update the Employee in the database

        {
            if (id != EmployeeVM.Id)
            {
                return BadRequest();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    var mappedEmployee = _mapper.Map<EmployeeViewModel, Employee>(EmployeeVM);
                    var count = _unitOfWork.employeeRepository.Delete(mappedEmployee);
                    _unitOfWork.Complete();
                    if (count > 0)
                        return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError(string.Empty, ex.Message);
                }



            }
            return View(EmployeeVM);

        }

    }
}
