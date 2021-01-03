using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebOdev.Models;

namespace WebOdev.Controllers
{
    public class YorumController : Controller
    {
        private readonly KitapDBContext _context;
        public YorumController(KitapDBContext kitap)
        {
            _context = kitap;

        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult YorumSil(int id)
        {
            var yorum = _context.Yorums.Find(id);
            try
            {
                _context.Remove(yorum);
                _context.SaveChanges();
            }
            catch(Exception e)
            {
                return Redirect("/Hata/Yorum");
            }
            return Redirect("/Anasayfa/Index");
        }
         [HttpPost]
        public IActionResult YorumGuncelle(Yorum yorum)
        {
            if(yorum.YorumId == 0)
            {
                return NotFound();
            }
            var yorumGetir = _context.Yorums.Find(yorum.YorumId);
            yorumGetir.Yorum1 = yorum.Yorum1;
            _context.Yorums.Update(yorumGetir);
            _context.SaveChanges();
            return Redirect("/Admin/Index");
        }
        [HttpPost]
        public IActionResult YorumEkle(Yorum yorum)
        {
            _context.Add(yorum);
            _context.SaveChanges();
            return Redirect("/Admin/Index");
        }
    }
}
