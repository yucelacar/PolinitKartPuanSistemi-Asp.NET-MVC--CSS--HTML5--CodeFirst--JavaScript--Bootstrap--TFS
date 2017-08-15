
using PolinitKartSistemi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PolinitKartSistemi.Areas.FirmaAdmin.Controllers
{
    public class FirmaAdminController : Controller
    {
        // GET: FirmaAdmin/FirmaAdmin
        public ActionResult PuanGuncelle()
        {
            var id = Request.QueryString["veri"];
            if (id=="0"||id==null)
            {
                  return RedirectToAction("Login", "../Home");    
            }
            else
            {
                //PolinitKartDbContext _db = new PolinitKartDbContext();
                //Firma firma = _db.Firmalar.Find(Convert.ToInt32(id));
                ViewBag.ID = id;
                Firma firma = new Firma();
                firma.FirmaID = Convert.ToInt32(id);
                return View(firma);
            }
        }

        [HttpPost]
        public ActionResult PuanGuncelle(Firma model)
        {
            if (FirmaAdminExtention.BirimPuanGüncelle(model))
            {
                ViewBag.Sonuc = "success";
                ViewBag.Mesaj = "Birim Puan tutarı güncellenmiştir";
                ViewBag.Icon = "glyphicon glyphicon-ok";
                ModelState.Clear();
            }
            else
            {
                ViewBag.sonuc = "danger";
                ViewBag.Mesaj = "Birim Puan tutarı güncellenememiştir lütfen virgüllü bir sayı giriniz!";
                ViewBag.Icon = "glyphicon glyphicon-remove";
            }

            return View();
        }

        
        public ActionResult KasiyerTanimla()
        {
            var id = Request.QueryString["veri"];
            if (id == "0" || id == null)
            {
                return RedirectToAction("Login", "../Home");
            }
            else
            {
                ViewBag.ID = id;
                Kasiyer kasiyer = new Kasiyer();
                kasiyer.FirmaID = Convert.ToInt32(id);
                return View(kasiyer);
            }
        }
        [HttpPost]
        public ActionResult KasiyerTanimla(Kasiyer model)
        {
            if (FirmaAdminExtention.FirmaKasiyerEkle(model))
            {
                ViewBag.Sonuc = "success";
                ViewBag.Mesaj = "Kasiyer Oluşturma Başarılı";
                ViewBag.Icon = "glyphicon glyphicon-ok";
                ModelState.Clear();
            }
            else
            {
                ViewBag.sonuc = "danger";
                ViewBag.Mesaj = "Kasiyer Oluşturma Başarısız!!!";
                ViewBag.Icon = "glyphicon glyphicon-remove";
            }
            return View();
        }
        public ActionResult Index(int? id)
        {
            if (id == 0 || id == null)
            {
                return RedirectToAction("Login", "../Home");
            }
            else
            {
                ViewBag.ID = id;
                return View();
            }
            
        }
        public ActionResult LogOut()
        {
            return RedirectToAction("Login", "../Home", new { veri = 0 });
        }
    }
}