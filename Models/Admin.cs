using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PolinitKartSistemi.Models
{
    [Table("Admin")]
    public class Admin
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AdminID { get; set; }
        [MaxLength(8), Required(ErrorMessage = "Bu alan zorunludur.")]
        public string Sifre { get; set; }
        [MaxLength(10), Required(ErrorMessage = "Bu alan zorunludur.")]
        public string KullaniciAdi { get; set; }
    }
}