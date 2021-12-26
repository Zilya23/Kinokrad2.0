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
    public class CollectionController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Collection> Get()
        {
            return Data.GetCollections();
        }

        [HttpGet("{id}")]
        public ActionResult<List<Film>> Get(int id)
        {
            var result = Data.GetFilm_Collections(id);
            if (result == null)
                return NotFound();

            return result;
        }
    }
}
