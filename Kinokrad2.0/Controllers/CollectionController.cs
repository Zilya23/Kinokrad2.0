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

        public IActionResult GetFilm_Collections(int ID_Collection)
        {
            return View(Data.GetFilm_Collections(ID_Collection));
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Collection collection)
        {
            Data.AddCollection(collection);
            return RedirectToAction("Index");
        }

        public IActionResult Remove(int ID_Film, int ID_Collection)
        {
            Data.DeleteFilm(ID_Film, ID_Collection);
            return RedirectToAction("GetFilm_Collections");
        }

        public IActionResult AddFilm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddFilm(Film_Collection fc)
        {
            Data.AddFilm_Collection(fc);
            return RedirectToAction("Index");
        }
    }
}
