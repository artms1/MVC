using NTierApp.BLL.Interfaces;
using NTierApp.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NTier.PL.Controllers
{
    public class CompanyController : Controller
    {
        private readonly ICompanyService companyService;

        public CompanyController(ICompanyService companyService)
        {
            this.companyService = companyService;
        }

        public ActionResult Index()
        {
          var companies = companyService.GetAllCompanies();
            return View(companies);
        }


        [HttpGet]
        public ActionResult Add()
        {
            CompanyModel company = new CompanyModel { Id = 1 };
            return View("Edit", company);
        }

        [HttpPost]
        public ActionResult Add(CompanyModel company)
        {
     
            companyService.AddCompany(company);
            return RedirectToAction("Index");
        }

  
    }
}