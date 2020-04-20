using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace api_versioning_demo.Controllers
{
    public class EmployeeV1Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}