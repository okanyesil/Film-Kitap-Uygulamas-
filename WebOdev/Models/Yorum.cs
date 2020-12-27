using System;
using System.Collections.Generic;

#nullable disable

namespace WebOdev.Models
{
    public partial class Yorum
    {
        public Yorum()
        {
            Kitaps = new HashSet<Kitap>();
        }

        public int YorumId { get; set; }
        public string Yorum1 { get; set; }

        public virtual ICollection<Kitap> Kitaps { get; set; }
    }
}
