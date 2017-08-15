using PolinitKartSistemi.Areas.Musteri.Models;
using PolinitKartSistemi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace PolinitKartSistemi.Areas.Musteri.Controllers
{
    public class MusteriController : Controller
    {
        // GET: Musteri/Musteri
        public ActionResult Index(int? id)
        {
            if (id==0||id==null)
            {
                return RedirectToAction("Login", "../Home");
            }
            else
            {
                ViewBag.ID = id;
                return View();
            }
        }
        [HttpGet]
        public ActionResult PuanTopla()
        {
            var id = Request.QueryString["veri"];
            if (id == "0"||id==null)
            {
                return RedirectToAction("Login", "../Home");
            }
            else
            {
                ViewBag.ID = id;
                KartTutarPuanViewModel karthesap = new KartTutarPuanViewModel();
                return View(karthesap);
            }


        }
        [HttpPost]
        public  ActionResult PuanTopla(KartTutarPuanViewModel model)
        {
            if (MusteriExtention.PuanAta(model))
            {
                return RedirectToAction("PuanHarca", "Musteri", new { area = "Musteri", id = model.KartNo });
            }
            else
            {
                ViewBag.Sonuc = "danger";
                ViewBag.Mesaj = "Puan Eklenemedi!";
                ViewBag.Icon = "glyphicon glyphicon-remove";
                return View();
            }
           
           
        }



        [HttpGet]
        public ActionResult PuanHarca(string id)
        {
            if (id==null)
            {
                return RedirectToAction("PuanTopla", "Musteri", new { area = "Musteri"});               
            }
            else
            {
                try
                {                    
                    
                    PolinitKartDbContext _db = new PolinitKartDbContext();
                    Kart kart = _db.Kartlar.Find(id);
                    KartTutarPuanViewModel karttutar = new KartTutarPuanViewModel();
                    karttutar.AlisverisTutari = kart.Puan * _db.Firmalar.Find(kart.FirmaID).BirimPuan;
                    karttutar.KartNo = kart.KartNo;
                    karttutar.Puan = kart.Puan;
                    karttutar.FirmaID =kart.FirmaID;
                    ViewBag.ID = karttutar.FirmaID;
                    return View(karttutar);
                }
                catch (Exception)
                {
                    return RedirectToAction("PuanTopla", "Musteri", new { area = "Musteri" });
                }
             
            }
            
        }


        [HttpPost]
        public ActionResult PuanHarca(KartTutarPuanViewModel model)
        {
            if (MusteriExtention.PuaniHarca(model))
            {
                
                return RedirectToAction("PuanTopla", "Musteri", new { area = "Musteri" });
            }
            else
            {
                ViewBag.Sonuc = "danger";
                ViewBag.Mesaj = "Puan Harcama Başarısız!";
                ViewBag.Icon = "glyphicon glyphicon-remove";
                return View();
            }
            
        }
        [HttpGet]
          
        public ActionResult MusteriEkle()
        {
            var id = Request.QueryString["veri"];
            if (id=="0"||id==null)
            {
                 return RedirectToAction("Login", "../Home");
            }
            else
            {
                ViewBag.ID = id;
                MusteriIletisimViewModel musteri = new MusteriIletisimViewModel();
                return View(musteri);
            }
      
        }
        [HttpPost]
        public ActionResult MusteriEkle(MusteriIletisimViewModel musteri)
        {
            if (MusteriExtention.MusteriTanımla(musteri))
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