using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kinokrad2._0.Controllers
{
    public class FCController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
