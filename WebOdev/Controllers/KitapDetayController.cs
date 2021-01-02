using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebOdev.Models;

namespace WebOdev.Controllers
{
    public class KitapDetayController : Controller
    {
        private readonly KitapDBContext _context;
        public KitapDetayController(KitapDBContext kitap)
        {
            _context = kitap;
        }
        public IActionResult Index(int id)
        {
            var kitapYorum = _context.Yorums.Where(yorum => yorum.YorumId ==id).ToList();

            return View(kitapYorum);
        }
    }
}
