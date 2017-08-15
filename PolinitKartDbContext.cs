using PolinitKartSistemi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PolinitKartSistemi
{
    public class PolinitKartDbContext:DbContext
    {
        public PolinitKartDbContext() : base("PolinitKart")
        {

        }
        public DbSet<KartSahibi> KartSahipleri { get; set; }
        public DbSet<Kart> Kartlar { get; set; }
        public DbSet<Firma> Firmalar { get; set; }
        public DbSet<MusteriIletisim> MusteriIletisimler { get; set; }
        public DbSet<FirmaIletisim> FirmaIletisimler { get; set; }        
        public DbSet<Admin> Adminler { get; set; }
        public DbSet<Kasiyer> Kasiyerler { get; set; }
    }
}