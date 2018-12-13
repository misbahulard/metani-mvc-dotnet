using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Metani.Models
{
    public class Lokasi
    {
        public int IdLokasi { get; set; }
        public string Kecamatan { get; set; }
        public string Kabupaten { get; set; }
        public string Provinsi { get; set; }
        public int KodePos { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
    }
}