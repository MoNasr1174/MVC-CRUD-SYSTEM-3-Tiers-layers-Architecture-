using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MVC.BLL.Interfaces;
using MVC.DAL.Models;
using MVC_.PL.ViewModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MVC_.PL.Controllers
{
    [Authorize]
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
        public async Task<IActionResult> Index(string searchInp)
        {
         

            IEnumerable<Employee> employees;
            if (string.IsNullOrEmpty(searchInp))
            {
                employees = await _unitOfWork.employeeRepository.GetAllAsync(); // Get All Employees
                
              
            }else
            {
               employees =  _unitOfWork.employeeRepository.GetEmployeeByName(searchInp);
              
            }

          await  _unitOfWork.CompleteAsync();

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



        public async Task<IActionResult> Create(EmployeeViewModel EmployeeVM) // that will add the Employee to the database
        {
            if (ModelState.IsValid)
            {
                var mappedEmployee = _mapper.Map<EmployeeViewModel, Employee >(EmployeeVM);
                await  _unitOfWork.employeeRepository.AddAsync(mappedEmployee);
                var count = await _unitOfWork.CompleteAsync();
                if (count > 0)
                    return RedirectToAction("Index");
            }
            return View(EmployeeVM);
        }


        [HttpGet]


        public async Task<IActionResult> Details(int? id, string ViewName = "Details") // that will return the view of update
        {
            if (!id.HasValue)
            {
                return BadRequest();
            }
            var Employee = await _unitOfWork.employeeRepository.GetByIdAsync(id.Value);



            var MappEmp = _mapper.Map<Employee, EmployeeViewModel>(Employee); 

            if (Employee == null)
            {
                return NotFound();
            }
            return View(ViewName, MappEmp);
        }


        [HttpGet]

        public async Task<IActionResult> Edit(int? id) // that will return the view of update
        {
            //ViewBag.Departments = _dapartmentRepository.GetAll();

            return await Details(id, "Edit");
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit([FromRoute] int id, EmployeeViewModel EmployeeVM) // that will update the Employee in the database

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
                    _unitOfWork.employeeRepository.Update(mappedEmployee);
                    var count = await _unitOfWork.CompleteAsync();
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

        public async Task<IActionResult> Delete(int? id) // that will return the view of update
        {
            return await Details(id, "Delete");
        }




        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete([FromRoute] int id, EmployeeViewModel EmployeeVM) // that will update the Employee in the database

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
                    _unitOfWork.employeeRepository.Delete(mappedEmployee);
                    var count = await _unitOfWork.CompleteAsync();
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
