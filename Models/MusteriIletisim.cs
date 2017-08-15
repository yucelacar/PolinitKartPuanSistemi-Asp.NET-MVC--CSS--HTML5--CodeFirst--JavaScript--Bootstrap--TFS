using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PolinitKartSistemi.Models
{
    public class MusteriIletisim
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MusteriIletisimID { get; set; }
        [MaxLength(100), Required(ErrorMessage = "Bu alan zorunludur.")]
        public string Adres { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        public string Telefon { get; set; }
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$"), Required(ErrorMessage = "Bu alan zorunludur.")]
        public string Email { get; set; }
        [DefaultValue(true)]
        public bool AktifMi { get; set; }
        public KartSahibi MusteriID { get; set; }
        public string Ilce { get; set; }
        public string Sehir { get; set; }
    }
}