using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PolinitKartSistemi.Models
{
    public class KullaniciGirisiModelView
    {
        [Required(ErrorMessage = "Bu alan zorunludur."),MinLength(4)]
        public string Sifre { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        public string KullaniciAdi { get; set; }
    }
}