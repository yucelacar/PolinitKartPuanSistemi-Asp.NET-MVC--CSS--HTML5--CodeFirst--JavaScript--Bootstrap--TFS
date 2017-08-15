using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PolinitKartSistemi.Areas.Yonetici.Models
{
    public class FirmaKartViewModel
    {
        public class FirmaIletisimViewModel
        {
            public int FirmaID { get; set; }
            public string FirmaAdi { get; set; }
            public string KartAdi { get; set; }
            public int KartNo { get; set; }

        }
    }
}