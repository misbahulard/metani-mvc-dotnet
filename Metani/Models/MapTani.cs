using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Metani.Models
{
    public class MapTani
    {
        public List<MapList> HasilTani { get; set; }
        public List<MapList> Tanah { get; set; }
        //public List<HasilTaniJoin> HasilTani { get; set; }
        //public List<TanahJoin> Tanah { get; set; }
    }
}