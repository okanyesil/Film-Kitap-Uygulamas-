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
        public IActionResult YazarSil(int id)
        {
            var yazar = _context.Yazars.Find(id);
            try
            {
                _context.Yazars.Remove(yazar);
                _context.SaveChanges();
            }
            catch(Exception e)
            {
                return Redirect("/Hata/Yazar");
            }
            return Redirect("/Admin/Index");
        }
        public IActionResult YazarGuncelle(Yazar yazar)
        {
            var yazarGetir = _context.Yazars.Find(yazar.YazarId);
            yazarGetir.YazarAdi = yazar.YazarAdi;
            yazarGetir.YazarSoyadi = yazar.YazarSoyadi;
            _context.Update(yazarGetir);
            _context.SaveChanges();
            return Redirect("/Admin/Index");
        }
    }
}
