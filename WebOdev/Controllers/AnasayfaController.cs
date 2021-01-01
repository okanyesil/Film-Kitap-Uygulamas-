using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebOdev.Models;

namespace WebOdev.Controllers
{
    public class AnasayfaController : Controller
    {
        private readonly KitapDBContext _context;
        public AnasayfaController(KitapDBContext kitap)
        {
            _context = kitap;

        }
        public IActionResult Index()
        {
            var kitapModel = new KategoryKitapModel();
            kitapModel.kategori = _context.Kategoris.ToList();
            kitapModel.kitap = _context.Kitaps.ToList();
            return View(kitapModel);
        }
    }
}
