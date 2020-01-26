using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebFormDemo.Models;

namespace WebFormDemo.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult GetDetails(int id)
        {
            EmployeeContext employeeContext = new EmployeeContext();
            Employee employee = employeeContext.Employees.Single(x => x.EmployeeId == id);

            return View(employee);
        }

        public ActionResult Index(int id)
        {
            EmployeeContext employeeContext = new EmployeeContext();
            List<Employee> employees = employeeContext.Employees.Where(x=>x.DepartmentId==id).ToList();
            return View(employees);
        }
    }
}