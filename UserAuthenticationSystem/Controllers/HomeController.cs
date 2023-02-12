using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using UserAuthenticationSystem.Models;

namespace UserAuthenticationSystem.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
     
        [Authorize(Policy = "OnlyForMicrosoft")]
        public IActionResult About()
        {
            return Content("Only for Microsoft employees");
        }
    }
}