using EclerxAshutoshRanaQuestion3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EclerxAshutoshRanaQuestion3.Controllers
{
   
    public class CompanyController : Controller
    {
        private readonly ApplicationDbContext _dbContext = null;

        public CompanyController()
        {
            _dbContext = new ApplicationDbContext();
        }
        // GET: Company
        public ActionResult index()
        {
            var company = _dbContext.companies.ToList();
            return View(company);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Company company)
        {
            if (ModelState.IsValid)
            {
                _dbContext.companies.Add(company);
                _dbContext.SaveChanges();
                return RedirectToAction("index");

            }
            return View();
        }
        
        public ActionResult Edit(int id)
        {
            var companydb = _dbContext.companies.FirstOrDefault(p => p.SupplierId == id);
            if (companydb != null)
            {
                return View(companydb);
            }
            return HttpNotFound();
        }

        [HttpPost]
        public ActionResult Edit(Company company)
        {
            var companyd = _dbContext.companies.FirstOrDefault(p => p.SupplierId == company.SupplierId);
            companyd.CompanyName = company.CompanyName;
            companyd.ContactName = company.ContactName;
            companyd.Address = company.Address;
            companyd.City = company.City;
            companyd.PinCode = company.PinCode;
            companyd.MobileNo = company.MobileNo;
            companyd.Email = company.Email;
            companyd.ModdifiedDate = company.ModdifiedDate;
            _dbContext.SaveChanges();
            return RedirectToAction("index")
        }
    }
}