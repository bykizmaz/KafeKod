﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafeKod.Data
{
    public class KafeVeri
    {
        public KafeVeri()
        {
            Urunler = new List<Urun>();
            AktifSiparisler = new List<Siparis>();
            GecmisSiparis = new List<Siparis>();
        }
        public List<Urun> Urunler { get; set; }

        public List<Siparis> AktifSiparisler { get; set; }

        public List<Siparis> GecmisSiparis { get; set; }

        public int MasaAdet { get; set; } = 20;
    }
}
