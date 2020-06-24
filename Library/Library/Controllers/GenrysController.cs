using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Library.Controllers
{
    [Route("catalog")]
    public class GenrysController : Controller
    {
        static readonly List<Genrys> data;
        static GenrysController()
        {
            using (LibContext db = new LibContext()) {
                data = db.Genrys.ToList();
            }
        }
        [HttpGet("")]
        public IEnumerable<Genrys> Get()
        {
            return data;
        }
    }
}