using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ödevs.Models;

namespace ödevs.Controllers
{
    public class musteriController : Controller
    {
        // GET: musteri
        public ActionResult MListele()
        {
            ViewData["Baslik"] = "MÜŞTERİ LİSTELEME";
            ViewBag.Altbilgi = "MODELDEN CONTROLLER ARACILIĞIYLA ÇEKİLİP GETİRİLMEKTEDİR";
            return View(ödevs.musteriveri.musteriveri.KMusteri);
        }
        public ActionResult YeniKayit()

        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniKayit(Models.musteri YeniMusteri)

        {
            ödevs.musteriveri.musteriveri.KMusteri.Add(YeniMusteri);
            return RedirectToAction("MListele");
        }
        public ActionResult Duzenle(int id)
        {

            ödevs.Models.musteri Duzenlenecekmusteri =
            ödevs.musteriveri.musteriveri.KMusteri.Where(o => o.Id == id).FirstOrDefault();
            return View(Duzenlenecekmusteri);
        }
        [HttpPost]
        public ActionResult Duzenle(ödevs.Models.musteri musteri)
        {
            ödevs.Models.musteri Duzenlenecekmusteri =
            ödevs.musteriveri.musteriveri.KMusteri.Where(o => o.Id == musteri.Id).FirstOrDefault();
            Duzenlenecekmusteri.Ad = musteri.Ad;
            Duzenlenecekmusteri.SoyAd = musteri.SoyAd;
            Duzenlenecekmusteri.Dogtar = musteri.Dogtar;
            Duzenlenecekmusteri.Adres = musteri.Adres;
            Duzenlenecekmusteri.TCkimlikno = musteri.TCkimlikno;
            return RedirectToAction("MListele");
        }
        public ActionResult Sil(int id)
        {

            ödevs.Models.musteri msil =
            ödevs.musteriveri.musteriveri.KMusteri.Where(o => o.Id == id).FirstOrDefault();
            return View(msil);
        }
        [HttpPost]
        public ActionResult Sil(ödevs.Models.musteri musteri)
        {
            ödevs.Models.musteri Silinecekmusteri =
            ödevs.musteriveri.musteriveri.KMusteri.Where(o => o.Id ==
            musteri.Id).FirstOrDefault();
            musteriveri.musteriveri.KMusteri.Remove(Silinecekmusteri);
            return RedirectToAction("MListele");
        }
    }
}