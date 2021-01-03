using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebOdev.Models;

namespace WebOdev.Controllers
{
    public class KategoriController : Controller
    {
        private readonly KitapDBContext _context;
        public KategoriController(KitapDBContext kitap)
        {
            _context = kitap;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult KategoriSil(Kategori kategori)
        {
            var kategoriGetir = _context.Kategoris.Find(kategori.KategoriId);
            try
            {
                _context.Kategoris.Remove(kategoriGetir);
                _context.SaveChanges();
            }
            catch(Exception e)
            {
                Redirect("/Hata/Yorum");
            }
            return Redirect("/Admin/Index");
        }
        public IActionResult KategoriGuncelle(Kategori kategori)
        {
            var kategoriGetir = _context.Kategoris.Find(kategori.KategoriId);
            kategoriGetir.KategoriAdi = kategori.KategoriAdi;
            _context.Update(kategoriGetir);
            _context.SaveChanges();
            return Redirect("/Admin/Index");
        }
    }
}
