using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PolinitKartSistemi.Areas.Musteri.Models
{
    public class MusteriIletisimViewModel
    {

        public string TcKimlikNo { get; set; }        
        public string KartNo { get; set; }
        public string MusteriAdi { get; set; }
        public string MusteriSoyadi { get; set; }
        public bool Cinsiyet { get; set; }
        public DateTime DogumTarihi { get; set; }    
        public string Adres { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string SehirAdi { get; set; }
        public string IlceAdi { get; set; }

    }
}