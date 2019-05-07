using MVS.LAB._2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVS.LAB._2.ViewModel
{
    public class EmployeeViewModel
    {
        public Employee Employee { get; set; }
        public List<Department> AllDepartments { get; set; }
    }
}