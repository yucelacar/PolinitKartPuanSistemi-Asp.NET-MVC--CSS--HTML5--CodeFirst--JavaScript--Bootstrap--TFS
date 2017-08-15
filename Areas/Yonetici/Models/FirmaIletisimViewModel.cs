using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PolinitKartSistemi.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace PolinitKartSistemi.Areas.Yonetici.Models
{
    public class FirmaIletisimViewModel
    {      
        public string FirmaAdi { get; set; }  
        public string Sifre { get; set; }
        public string KullaniciAdi { get; set; }
        public string Adres { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string SehirAdi { get; set; }          
        public string IlceAdi { get; set; }
        public int KartBaslangicNo { get; set; }
        public int KartAdedi { get; set; }
        public double BirimPuan { get; set; }

    }
}