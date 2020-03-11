using NTierApp.BLL.Interfaces;
using NTierApp.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NTier.PL.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }

        public ActionResult Index()
        {
            var employees = employeeService.GetAllEmloyees();
            return View(employees);
        }


        [HttpGet]
        public ActionResult Add()
        {
            EmployeeModel employee = new EmployeeModel { Id = 1 };
            return View("Edit", employee);
        }

        [HttpPost]
        public ActionResult Add(EmployeeModel employee)
        {

            employeeService.AddEmployee(employee);
            return RedirectToAction("Index");
        }


    }
}