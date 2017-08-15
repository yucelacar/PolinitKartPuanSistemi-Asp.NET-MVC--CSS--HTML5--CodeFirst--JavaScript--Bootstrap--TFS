using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PolinitKartSistemi.Models
{
    [Table("FirmaIletisim")]
    public class FirmaIletisim
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MusteriIletisimID { get; set; }
        [MaxLength(100)]
        public string Adres { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string Telefon { get; set; }
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$"), Required(ErrorMessage = "Bu alan zorunludur.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DefaultValue(true)]
        public bool AktifMi { get; set; }
        public Firma Firmalar { get; set; }

        public string Ilce { get; set; }
        public string Sehir { get; set; }
    }
}