using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebFormDemo.Models;

namespace WebFormDemo.Controllers
{
    public class DepartmentController : Controller
    {
        // GET: Department
        public ActionResult Index()
        {
            EmployeeContext departmentList = new EmployeeContext();
            List<Department> departments = departmentList.departments.ToList();
            return View(departments);
        }
    }
}