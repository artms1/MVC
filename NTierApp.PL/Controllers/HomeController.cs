using Autofac;
using NTierApp.BLL;
using NTierApp.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NTierApp.PL.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmployeeService _employeeService;


        public HomeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;

        }
        public ActionResult Index()
        {
            var employees = _employeeService.GetAllEmloyees();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}