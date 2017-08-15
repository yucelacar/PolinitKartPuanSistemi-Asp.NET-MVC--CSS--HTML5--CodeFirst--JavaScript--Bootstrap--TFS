using PolinitKartSistemi.Areas.Yonetici.Models;
using PolinitKartSistemi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PolinitKartSistemi.Areas.Yonetici
{
    public class YoneticiExtention
    {
        private static int FirmaIdOlustur()
        {
            Random rnd = new Random();
            return rnd.Next(100000, 999999);
        }
        public static bool FirmaTanımla(FirmaIletisimViewModel model)
        {
            PolinitKartDbContext _db = new PolinitKartDbContext();
            try
            {

                Firma firma = new Firma();
                firma.FirmaAdi = model.FirmaAdi;
                firma.Sifre = model.Sifre;
                firma.KullaniciAdi = model.KullaniciAdi;
                firma.FirmaID = FirmaIdOlustur();
                firma.BirimPuan = model.BirimPuan;
                _db.Firmalar.Add(firma);
                _db.SaveChanges();
                firma.FirmaIletisimler.Add(new FirmaIletisim() { Adres = model.Adres, Email = model.Email, Ilce = model.IlceAdi, Sehir = model.SehirAdi, Telefon = model.Telefon });
                _db.SaveChanges();

                for (int i = 0; i < model.KartAdedi; i++)
                {
                    if (i < 10)
                    {
                        firma.Kartlar.Add(new Kart() { KartNo = model.KartBaslangicNo.ToString() + firma.FirmaID.ToString() + "00000" + i.ToString() });
                        _db.SaveChanges();
                    }
                    else if (i < 100)
                    {
                        firma.Kartlar.Add(new Kart() { KartNo = model.KartBaslangicNo.ToString() + firma.FirmaID.ToString() + "0000" + i.ToString() });
                        _db.SaveChanges();
                    }
                    else if (i < 1000)
                    {
                        firma.Kartlar.Add(new Kart() { KartNo = model.KartBaslangicNo.ToString() + firma.FirmaID.ToString() + "000" + i.ToString() });
                        _db.SaveChanges();
                    }
                    else if (i < 10000)
                    {
                        firma.Kartlar.Add(new Kart() { KartNo = model.KartBaslangicNo.ToString() + firma.FirmaID.ToString() + "00" + i.ToString() });
                        _db.SaveChanges();
                    }
                    else if (i < 100000)
                    {
                        firma.Kartlar.Add(new Kart() { KartNo = model.KartBaslangicNo.ToString() + firma.FirmaID.ToString() + "0" + i.ToString() });
                        _db.SaveChanges();
                    }
                    else
                    {
                        firma.Kartlar.Add(new Kart() { KartNo = model.KartBaslangicNo.ToString() + firma.FirmaID.ToString() + i.ToString() });
                        _db.SaveChanges();
                    }

                  
                }
                return true;
            }
            catch (Exception)
            {
                return false;

            }
        }

    }
}