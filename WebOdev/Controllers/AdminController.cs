﻿using System;
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
        public IActionResult KitapEkle()
        {
            return View();
        }
        public IActionResult KitapSil(int id)
        {
            var kitap = _context.Kitaps.Find(id);
            return View(kitap);
        }
        public IActionResult KitapGuncelle(int id)
        {
            var kitap = _context.Kitaps.Find(id);
            return View(kitap);
        }
        public IActionResult KategoriSil(int id)
        {
            var kategori = _context.Kategoris.Find(id);
            return View(kategori);
        }
        public IActionResult KategoriGuncelle(int id)
        {
            var kategori = _context.Kategoris.Find(id);
            return View(kategori);
        }
        public IActionResult KategoriEkle()
        {
            return View();
        }
        public IActionResult YorumSil(int id)
        {
            var yorum = _context.Yorums.Find(id);
            return View(yorum);
        }
        public IActionResult YorumGuncelle(int id)
        {
            var yorum = _context.Yorums.Find(id);
            return View(yorum);
        }
        public IActionResult YorumEkle()
        {
            return View();
        }
        public IActionResult YazarSil(int id)
        {
            var yazar = _context.Yazars.Find(id);
            return View(yazar);
        }
        public IActionResult YazarGuncelle(int id)
        {
            var yazar = _context.Yazars.Find(id);
            return View(yazar);
        }
        public IActionResult YazarEkle()
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
