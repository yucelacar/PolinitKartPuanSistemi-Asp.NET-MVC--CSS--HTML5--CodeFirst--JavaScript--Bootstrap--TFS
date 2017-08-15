using PolinitKartSistemi.Areas.Musteri.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PolinitKartSistemi.Models;

namespace PolinitKartSistemi.Areas.Musteri
{
    public class MusteriExtention
    {
      
        public static bool MusteriTanımla(MusteriIletisimViewModel model)
        {

            try
            {
                PolinitKartDbContext _db = new PolinitKartDbContext();
                KartSahibi kartsahibi = new KartSahibi();
                kartsahibi.Cinsiyet = model.Cinsiyet;
                kartsahibi.DogumTarihi = model.DogumTarihi;
                kartsahibi.MusteriAdi = model.MusteriAdi;
                kartsahibi.MusteriSoyadi = model.MusteriSoyadi;
                kartsahibi.TcKimlikNo = model.TcKimlikNo;
                kartsahibi.AktifMi = true;


                _db.KartSahipleri.Add(kartsahibi);
                //_db.SaveChanges();

                kartsahibi.MusteriIletisimler.Add(new MusteriIletisim { Adres = model.Adres, Email = model.Email, Ilce = model.IlceAdi, Sehir = model.SehirAdi, Telefon = model.Telefon });
                _db.SaveChanges();


                Kart kart = _db.Kartlar.Find(model.KartNo);
                kart.KartSahibi = kartsahibi;
                kart.AktifMi = true;
                _db.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;

            }
        }

        public static bool PuanAta(KartTutarPuanViewModel model)
        {
            try
            {
                PolinitKartDbContext _db = new PolinitKartDbContext();
                Kart kart = _db.Kartlar.Find(model.KartNo);
                kart.Puan = model.AlisverisTutari + kart.Puan;
                _db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;

            }
        }

        public static bool PuaniHarca(KartTutarPuanViewModel model)
        {
            try
            {
                PolinitKartDbContext _db = new PolinitKartDbContext();
                Kart kart = _db.Kartlar.Find(model.KartNo);
                kart.Puan = kart.Puan - model.KullanilanIndirim / _db.Firmalar.Find(kart.FirmaID).BirimPuan;
                _db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;

            }
        }
    
    }
}