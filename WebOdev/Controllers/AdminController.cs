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
        public IActionResult KitapSil(int id)
        {
            var kitap = _context.Kitaps.Where(kitap => kitap.KitapId == id).ToList();
            return View(kitap);
        }
        public IActionResult KategoriSil(int id)
        {
            var kategori = _context.Kategoris.Where(kategori => kategori.KategoriId == id).ToList();
            return View(kategori);
        }
        public IActionResult YorumSil(int id)
        {
            var yorum = _context.Yorums.Where(yorum => yorum.YorumId == id).ToList();
            return View(yorum);
        }
        public IActionResult YazarSil(int id)
        {
            var yazar = _context.Yazars.Where(yazar => yazar.YazarId == id).ToList();
            return View(yazar);
        }
        public IActionResult YazarGuncelle(int id)
        {
            var yazar = _context.Yazars.Where(yazar => yazar.YazarId == id).ToList();
            return View(yazar);
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
