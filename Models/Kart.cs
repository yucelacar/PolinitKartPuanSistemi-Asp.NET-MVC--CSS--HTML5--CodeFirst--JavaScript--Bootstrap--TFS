using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PolinitKartSistemi.Models
{
    [Table("Kart")]
    public class Kart
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string KartNo { get; set; }
        [DefaultValue(0)]
        public double Puan { get; set; }
        public int FirmaID { get; set; }
        [ForeignKey("FirmaID")]
        public Firma Firma { get; set; }
        [DefaultValue(false)]
        public bool AktifMi { get; set; }
        public KartSahibi KartSahibi { get; set; }
    }
}