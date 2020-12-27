using System;
using System.Collections.Generic;

#nullable disable

namespace WebOdev.Models
{
    public partial class Kategori
    {
        public Kategori()
        {
            Kitaps = new HashSet<Kitap>();
        }

        public int KategoriId { get; set; }
        public string KategoriAdi { get; set; }

        public virtual ICollection<Kitap> Kitaps { get; set; }
    }
}
