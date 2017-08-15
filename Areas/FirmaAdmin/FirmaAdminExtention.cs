using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PolinitKartSistemi.Models;

namespace PolinitKartSistemi.Areas.FirmaAdmin
{
    public class FirmaAdminExtention
    {
        public static bool BirimPuanGüncelle(Firma model)
        {
            try
            {
                PolinitKartDbContext _db = new PolinitKartDbContext();
                Firma firma = _db.Firmalar.Find(model.FirmaID);
                firma.BirimPuan = model.BirimPuan;
                _db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;

            }
        }

        public static bool FirmaKasiyerEkle(Kasiyer model)
        {
            try
            {
                PolinitKartDbContext _db = new PolinitKartDbContext();
                model.AktifMi = true;
                _db.Kasiyerler.Add(model);
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