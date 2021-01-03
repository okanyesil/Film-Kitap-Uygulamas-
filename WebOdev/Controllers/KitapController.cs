using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebOdev.Models;

namespace WebOdev.Controllers
{
    public class KitapController : Controller
    {
        private readonly KitapDBContext _context;
        public KitapController(KitapDBContext kitap)
        {
            _context = kitap;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult KitapSil(Kitap kitap)
        {
            if(kitap == null)
            {
                return BadRequest();
            }
            var kitapGetir = _context.Kitaps.Find(kitap.KitapId);
            try
            {
                _context.Remove(kitapGetir);
                _context.SaveChanges();
            }
            catch(Exception e)
            {
                return NotFound();
            }
            return Redirect("/Admin/Index");
        }
        public IActionResult KitapGuncelle(Kitap kitap)
        {
            if (kitap == null)
            {
                return BadRequest();
            }
            var kitapGetir = _context.Kitaps.Find(kitap.KitapId);

            kitapGetir.KitapAdi = kitap.KitapAdi;
            kitapGetir.YazarId = kitap.YazarId;
            kitapGetir.KategoryId = kitap.KategoryId;
            kitapGetir.YorumId = kitap.YorumId;
            kitapGetir.ResimUrl = kitap.ResimUrl;
            kitapGetir.Puan = kitap.Puan;
            _context.Kitaps.Update(kitapGetir);
            _context.SaveChanges();

            return Redirect("/Admin/Index");

        }
    }
}
