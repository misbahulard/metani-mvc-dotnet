using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Metani.Models
{
    public class TanahLokasi
    {
        public IEnumerable<JenisTanah> jenisTanah { get; set; }
        public IEnumerable<Lokasi> lokasi { get; set; }
        public Tanah tanah { get; set; }
    }
}