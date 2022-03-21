using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class ErorPageController : Controller
    {
        public IActionResult Eror1(int code)
        {
            return View();
        }
    }
}
