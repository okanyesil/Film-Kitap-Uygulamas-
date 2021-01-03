using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebOdev.Controllers
{
    public class HataController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Yazar()
        {
            return View();
        }
        public IActionResult Yorum()
        {
            return View();
        }
        public IActionResult Kategori()
        {
            return View();
        }

    }
}
