using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core;

namespace Kinokrad2._0.Controllers
{
    public class CollectionController : Controller
    {
        public IActionResult Index()
        {
            return View(Data.GetCollections());
        }
    }
}
