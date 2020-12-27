using System;
using System.Collections.Generic;

#nullable disable

namespace WebOdev.Models
{
    public partial class Yazar
    {
        public Yazar()
        {
            Kitaps = new HashSet<Kitap>();
        }

        public int YazarId { get; set; }
        public string YazarAdi { get; set; }
        public string YazarSoyadi { get; set; }

        public virtual ICollection<Kitap> Kitaps { get; set; }
    }
}
