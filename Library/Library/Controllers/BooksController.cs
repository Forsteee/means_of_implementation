using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    [Route("resoursess")]
    public class BooksController : Controller
    {
        static readonly List<Books> data;
        static BooksController()
        {
            using (LibContext db = new LibContext())
            {
                data = db.Books.ToList();
            }
        }

        [HttpGet("")]
        public IEnumerable<Books> Get() {
                return data;        
        }
    }
}