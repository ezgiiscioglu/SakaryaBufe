using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SakaryaBufe.Controllers
{
    public class UyelikController : Controller
    {
        SakaryaBufe.SakaryaBufeEntities3 db = new SakaryaBufeEntities3();
        // GET: Kullanici
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]

        public ActionResult KullanıcıEkle(string Ad, string Sifre, string Eposta, string Telefon, string Adres)   //Baslik string geldigi için string alınır
        {
            Kullanici k = new Kullanici();
            k.Ad = Ad;
            k.Sifre = Sifre;
            k.Eposta = Eposta;
            k.Telefon = Telefon;
            k.Adres = Adres;
            db.Kullanicis.Add(k);
            db.SaveChanges();

            return Redirect("KullanıcıGirisYap");    // Siparis gönderildikten sonra index sayfasına dönmek için
        }

        public ActionResult KullanıcıGirisYap()
        {
            return View();

        }
        [HttpPost]
        public ActionResult KullanıcıGirisYap(string Sifre, string Eposta)
        {
            KullaniciGiri kg = new KullaniciGiri();
            kg.Eposta = Eposta;
            kg.Sifre = Sifre;
            return Redirect("/");
        }
    }
}