using MVS.LAB._2.Models;
using MVS.LAB._2.ViewModel;
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
            TempData["status"] ="Add";
            EmployeeViewModel employeeVM = new EmployeeViewModel
            {
                AllDepartments = context.Departments.ToList(),
            };
            return View("AddAndEditForm", employeeVM);
        }
        [HttpPost]
        public ActionResult Add(Employee Employee)
        {
            EmployeeViewModel employeeVM = new EmployeeViewModel
            {
                //AllDepartments = context.Departments.ToList(),
                Employee = Employee
            };
            if (ModelState.IsValid)
            {
                context.Employees.Add(employeeVM.Employee);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("AddAndEditForm", employeeVM);
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
            TempData["status"] = "Edit";

            EmployeeViewModel employeeVM = new EmployeeViewModel
            {
                Employee = context.Employees.Find(id),
                AllDepartments = context.Departments.ToList(),
            };
            if (employeeVM.Employee != null)
            {
                return View("AddAndEditForm", employeeVM);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Edit(Employee Employee)
        {
            //EmployeeViewModel employeeVM = new EmployeeViewModel
            //{
            //    AllDepartments = context.Departments.ToList(),
            //    Employee = e
            //};
            var x = ViewBag.EmployeeId;
            Employee res = context.Employees.FirstOrDefault(emp => emp.Id == Employee.Id);
            res.Name = Employee.Name;
            res.Salary = Employee.Salary;
            res.Dept_FK = Employee.Dept_FK;
            res.Gender = Employee.Gender;
            context.SaveChanges();
            return RedirectToAction("Index");

        }
    }

}