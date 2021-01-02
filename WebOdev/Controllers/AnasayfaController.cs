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
        public IActionResult Index(int id)
        {
            var kitapModel = new KategoryKitapModel();
            if(id ==  0)
            {
                kitapModel.kategori = _context.Kategoris.ToList();
                kitapModel.kitap = _context.Kitaps.ToList();
                kitapModel.Yazar = _context.Yazars.ToList();
            }
            else
            {
                kitapModel.kitap = _context.Kitaps.Where(data => data.KategoryId == id).ToList();
                kitapModel.Yazar = _context.Yazars.ToList();
            }
            return View(kitapModel);
        }
        public IActionResult Kategori(int id)
        {
            var kitapModel = new KategoryKitapModel();
            kitapModel.kitap = _context.Kitaps.Where(data => data.KategoryId == id).ToList();
            kitapModel.Yazar = _context.Yazars.ToList();
            return View(kitapModel);
        }
    }
}
