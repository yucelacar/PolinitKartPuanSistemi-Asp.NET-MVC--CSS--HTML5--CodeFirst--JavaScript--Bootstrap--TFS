using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PolinitKartSistemi.Models
{

    [Table("Firma")]
    public class Firma
    {
        public Firma()
        {
            FirmaIletisimler = new HashSet<FirmaIletisim>();
            Kartlar = new HashSet<Kart>();
            Kasiyerler=new HashSet<Kasiyer>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FirmaID { get; set; }
        [MaxLength(30), Required(ErrorMessage = "Bu alan zorunludur.")]
        public string FirmaAdi { get; set; }
        [DefaultValue(true)]
        public bool AktifMi { get; set; }
        [MaxLength(8), Required(ErrorMessage = "Bu alan zorunludur.")]
        public string Sifre { get; set; }
        [MaxLength(10), Required(ErrorMessage = "Bu alan zorunludur.")]
        public string KullaniciAdi { get; set; }
        public ICollection<Kart> Kartlar { get; set; }
        public ICollection<FirmaIletisim> FirmaIletisimler { get; set; }
        public ICollection<Kasiyer> Kasiyerler { get; set; }
        [DefaultValue(5/100)]
        public double BirimPuan { get; set; }
    }

}