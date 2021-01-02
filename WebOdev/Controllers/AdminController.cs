using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebOdev.Models;

namespace WebOdev.Controllers
{
    public class AdminController : Controller
    {
        private readonly KitapDBContext _context;
        public AdminController(KitapDBContext kitap)
        {
            _context = kitap;

        }
        public IActionResult Index()
        {
            var tumIcerik = new KitapYazarYorumKategoriModel();
            tumIcerik.Kitaplar = _context.Kitaps.ToList();
            tumIcerik.Yazarlar = _context.Yazars.ToList();
            tumIcerik.Yorumlar = _context.Yorums.ToList();
            tumIcerik.Kategoriler = _context.Kategoris.ToList();
            return View(tumIcerik);
        }
        public IActionResult Ekle()
        {
            return View();
        }
        public IActionResult Guncelle()
        {
            return View();
        }
        public IActionResult Sil()
        {
            return View();
        }
    }
}
