using PolinitKartSistemi.Models;
using System.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace PolinitKartSistemi.Controllers
{
    public class HomeController : Controller
    {
        PolinitKartDbContext _db;
        public HomeController()
        {
            _db = new PolinitKartDbContext();
        }
        // GET: Home
        [HttpGet]
        public ActionResult Login()
        {
            KullaniciGirisiModelView kullanici = new KullaniciGirisiModelView();
            return View(kullanici);
        }
        [HttpPost]
        public ActionResult Login(KullaniciGirisiModelView model)
        {
         
            return KullaniciKontrol(model);

        }

        private ActionResult KullaniciKontrol(KullaniciGirisiModelView model)
        {
            if (_db.Adminler.Where(x => x.KullaniciAdi == model.KullaniciAdi && x.Sifre == model.Sifre).FirstOrDefault() != null)
            {
            
                return RedirectToAction("FirmaTanimla", "Yonetici", new { area = "Yonetici" ,id= _db.Adminler.Where(x => x.KullaniciAdi == model.KullaniciAdi && x.Sifre == model.Sifre).FirstOrDefault().AdminID});  //Olusturuldugunda doldurulacak.
            }
            else if (_db.Firmalar.Where(x => x.KullaniciAdi == model.KullaniciAdi && x.Sifre == model.Sifre).FirstOrDefault() != null)
            {
                return RedirectToAction("Index", "FirmaAdmin", new { area = "FirmaAdmin", id = _db.Firmalar.Where(x => x.KullaniciAdi == model.KullaniciAdi && x.Sifre == model.Sifre).FirstOrDefault().FirmaID });
             
           
            }
            else if (_db.Kasiyerler.Where(x => x.KullaniciAdi == model.KullaniciAdi && x.Sifre == model.Sifre).FirstOrDefault() != null)
            {
           
                return RedirectToAction("Index", "Musteri", new { area = "Musteri", id = _db.Kasiyerler.Where(x => x.KullaniciAdi == model.KullaniciAdi && x.Sifre == model.Sifre).FirstOrDefault().FirmaID});
                
            }
            else
            {
                ViewBag.sonuc = "danger";           
                ViewBag.Mesaj = "Hatalı Kullanıcı Adı veya Şifre girildi.";
                return View();
            }
        }

    }
}