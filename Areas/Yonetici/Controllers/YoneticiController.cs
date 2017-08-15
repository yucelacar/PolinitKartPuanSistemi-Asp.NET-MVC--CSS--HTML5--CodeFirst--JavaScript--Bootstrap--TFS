using PolinitKartSistemi.Areas.Yonetici.Models;
using PolinitKartSistemi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PolinitKartSistemi.Areas.Yonetici.Controllers
{
    public class YoneticiController : Controller
    {
        PolinitKartDbContext _db;
        public YoneticiController()
        {
            _db = new PolinitKartDbContext();
        }
        // GET: Yonetici/Yonetici
        [HttpGet]
        public ActionResult FirmaTanimla(int id)
        {
            if (id==0)
            {
                return RedirectToAction("Login", "Home");
            }
            else
            {
                FirmaIletisimViewModel firma = new FirmaIletisimViewModel();
                return View(firma);
            }
            
         
        }
        [HttpPost]
        public ActionResult FirmaTanimla(FirmaIletisimViewModel model)
        {
            if (YoneticiExtention.FirmaTanımla(model))
            {
                ViewBag.Sonuc = "success";
                ViewBag.Mesaj = "Kayıt Oluşturma Başarılı!";
                ViewBag.Icon = "glyphicon glyphicon-ok";
                ModelState.Clear();
            }
            else
            {
                ViewBag.Sonuc = "danger";
                ViewBag.Mesaj = "Kayıt Oluşturma Başarısız!";
                ViewBag.Icon = "glyphicon glyphicon-remove";
                
            }

            return View();
        }

        public ActionResult LogOut()
        {
            return RedirectToAction("Login", "../Home", new { veri = 0 });
        }
       


      
    }
}
