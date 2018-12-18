using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Metani.Models
{
    public class HasilTaniJoin
    {
        public int IdHasilTani { get; set; }
        public JenisTani jenisTani { get; set; }
        public int Jumlah { get; set; }
        public Lokasi lokasi { get; set; }
    }
}