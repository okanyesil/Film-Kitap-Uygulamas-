using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebOdev.Models
{
    public class KitapYorumModel
    {
        public IEnumerable<Yorum> Yorumlar { get; set; }
        public IEnumerable<Kitap> Kitap { get; set; }
    }
}
