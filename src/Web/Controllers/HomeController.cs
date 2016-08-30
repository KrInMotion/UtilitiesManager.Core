using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        // GET:/Home/Index
        public IActionResult Index()
        {
            return View();
        }
        
        // GET:/Home/ErrorStatus/{id}
        public IActionResult ErrorStatus(int id)
        {
            return View("ErrorStatus", id);
        }
    }
}