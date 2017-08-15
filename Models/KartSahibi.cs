using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PolinitKartSistemi.Models
{
    [Table("KartSahipleri")]
    public class KartSahibi
    {
        public KartSahibi()
        {
            Kartlar = new HashSet<Kart>();
            MusteriIletisimler = new HashSet<MusteriIletisim>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string TcKimlikNo { get; set; }
        [MaxLength(30), Required(ErrorMessage = "Bu alan zorunludur.")]
        public string MusteriAdi { get; set; }
        [MaxLength(30), Required(ErrorMessage = "Bu alan zorunludur.")]
        public string MusteriSoyadi { get; set; }
        public bool Cinsiyet { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        public DateTime DogumTarihi { get; set; }
        [DefaultValue(true)]
        public bool AktifMi { get; set; }
        public ICollection<Kart> Kartlar { get; set; }
        public ICollection<MusteriIletisim> MusteriIletisimler { get; set; }
    }
}