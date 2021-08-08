using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class EmpController : Controller
    {
        // GET: Emp
        DatabaseContext _db = new DatabaseContext();

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(tblEmployeeNew _empnew)
        {
            if (ModelState.IsValid)
            {
                tblEmployee _emp = new tblEmployee();
                _emp.Name = _empnew.Name;
                _emp.Age = _empnew.Age;
                _db.tblEmployees.Add(_emp);
                _db.SaveChanges();
                return View();
            }
            else 
            {
                return View();
            }
        }

    }
}