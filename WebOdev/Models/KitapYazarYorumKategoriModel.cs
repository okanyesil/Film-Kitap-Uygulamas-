using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebOdev.Models
{
    public class KitapYazarYorumKategoriModel
    {
        public IEnumerable<Kitap> Kitaplar { get; set; }
        public IEnumerable<Yazar> Yazarlar { get; set; }
        public IEnumerable<Yorum> Yorumlar { get; set; }
        public IEnumerable<Kategori> Kategoriler { get; set; }
    }
}
