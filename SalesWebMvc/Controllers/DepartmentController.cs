using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models;

namespace SalesWebMvc.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            List<Department> deptList = new List<Department>();
            deptList.Add(new Department { Id = 1, Name = "Eletronics" });
            deptList.Add(new Department { Id = 2, Name = "Fashion" });
            return View(deptList);
        }
    }
}
