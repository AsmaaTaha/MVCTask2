using MVS.LAB._2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVS.LAB._2.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        Model context = new Model();
        public ActionResult Index()
        {
            var employees = context.Employees.ToList();
            return View(employees);
        }
        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(Employee e)
        {
            if (ModelState.IsValid)
            {
                context.Employees.Add(e);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(e);
        }
        public ActionResult Delete(int id)
        {
            Employee res = context.Employees.Find(id);
           if (res!=null)
            {
                context.Employees.Remove(res);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
 
        [HttpGet]
        public ActionResult Edit(int id)
        {
            Employee res = context.Employees.Find(id);
            if (res != null)
            {
            return View(res);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Edit(Employee e)
        {
            Employee res = context.Employees.FirstOrDefault(emp=>emp.Id==e.Id);
            res.Name = e.Name;
            res.Salary = e.Salary;
            context.SaveChanges();
            return RedirectToAction("Index");

        }
    }

}