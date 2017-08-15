using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace PolinitKartSistemi.Areas.Musteri.Models
{
    public class KartTutarPuanViewModel
    {
        public int FirmaID { get; set; }
        public string KartNo { get; set; }
        public double  AlisverisTutari { get; set; }
        public double Puan { get; set; }
        public double KullanilanIndirim { get; set; }
    }
}