using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Metani.Models
{
    public class TanahJoin
    {
        public int IdTanah { get; set; }
        public Lokasi Lokasi { get; set; }
        public JenisTanah JenisTanah { get; set; }
        public int LuasTanah { get; set; }
        public int Suhu { get; set; }
    }
}