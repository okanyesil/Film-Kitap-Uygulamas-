using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebOdev.Models
{
    public class KategoryKitapModel
    {
       
        public IEnumerable<Kategori> kategori { get; set; }
        public IEnumerable<Kitap> kitap { get; set; }
    }
}
