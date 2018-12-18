using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Metani.Models
{
    public class TaniLokasi
    {
        public IEnumerable<JenisTani> jenisTani { get; set; }
        public IEnumerable<Lokasi> lokasi { get; set; }
        public HasilTani hasilTani { get; set; }
    }
}