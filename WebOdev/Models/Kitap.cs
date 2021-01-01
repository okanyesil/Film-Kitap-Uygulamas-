using System;
using System.Collections.Generic;

#nullable disable

namespace WebOdev.Models
{
    public partial class Kitap
    {
        public int KitapId { get; set; }
        public string KitapAdi { get; set; }
        public int? YazarId { get; set; }
        public int? KategoryId { get; set; }
        public int? YorumId { get; set; }
        public string ResimUrl { get; set; }
        public short? Puan { get; set; }

        public virtual Kategori Kategory { get; set; }
        public virtual Yazar Yazar { get; set; }
        public virtual Yorum Yorum { get; set; }
    }
}
