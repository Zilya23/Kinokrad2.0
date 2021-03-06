using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core;

namespace API_Interface1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Film> Get()
        {
            return Data.GetFilms();
        }

        [HttpGet("{id}")]
        public ActionResult<List<Film>> Get(int id)
        {
            var result = Data.GetFilmID(id);
            if (result == null)
                return NotFound();

            return result;
        }

        [HttpPost]
        public IActionResult Create(Film film)
        {
            Data.AddFilm(film);
            return NoContent();
        }
    }
}
