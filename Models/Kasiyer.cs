using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PolinitKartSistemi.Models
{
    [Table("Kasiyer")]
    public class Kasiyer
    {
        public int ID { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        [DefaultValue(true)]
        public bool AktifMi { get; set; }
        public int FirmaID { get; set; }
        [ForeignKey("FirmaID")]
        public Firma Firma { get; set; }

    }
}