using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Metani.Models
{
    public class Tanah
    {
        public int IdTanah { get; set; }
        public int IdLokasi { get; set; }
        public int IdJenisTanah { get; set; }
        public int LuasTanah { get; set; }
        public int Suhu { get; set; }
    }
}