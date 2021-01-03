using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebOdev.Models;

namespace WebOdev.Controllers
{
    public class YazarController : Controller
    {
        private readonly KitapDBContext _context;
        public YazarController(KitapDBContext kitap)
        {
            _context = kitap;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult YazarSil(Yazar yazar)
        {
            var yazarGetir = _context.Yazars.Find(yazar.YazarId);
            try
            {
                _context.Yazars.Remove(yazarGetir);
                _context.SaveChanges();
            }
            catch(Exception e)
            {
                return Redirect("/Hata/Yazar");
            }
            return Redirect("/Admin/Index");
        }
        [HttpPost]
        public IActionResult YazarGuncelle(Yazar yazar)
        {
            if(yazar.YazarId == 0)
            {
                return NotFound();
            }
            var yazarGetir = _context.Yazars.Find(yazar.YazarId);
            yazarGetir.YazarAdi = yazar.YazarAdi;
            yazarGetir.YazarSoyadi = yazar.YazarSoyadi;
            _context.Update(yazarGetir);
            _context.SaveChanges();
            return Redirect("/Admin/Index");
        }
        [HttpPost]
        public IActionResult YazarEkle(Yazar yazar)
        {
            _context.Yazars.Add(yazar);
            _context.SaveChanges();
            return Redirect("/Admin/Index");
        }
    }
}
