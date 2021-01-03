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
        public IActionResult KategoriSil(int id)
        {
            if(id == 0)
            {
                return BadRequest();
            }
            var kategori = _context.Kategoris.Find(id);
            try
            {
                _context.Kategoris.Remove(kategori);
                _context.SaveChanges();
            }
            catch(Exception e)
            {
                Redirect("/Hata/Yorum");
            }
            return Redirect("/Admin/Index");
        }
    }
}
