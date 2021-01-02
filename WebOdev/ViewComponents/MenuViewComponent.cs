using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebOdev.Models;

namespace WebOdev.ViewComponents
{
    [ViewComponent]
    public class MenuViewComponent: ViewComponent
    {
        private readonly KitapDBContext _context;
        public MenuViewComponent(KitapDBContext kitap)
        {
            _context = kitap;
        }
        public IViewComponentResult Invoke()
        {
            var kitap = _context.Kategoris.ToList();
            return View(kitap);
        }
    }
}
