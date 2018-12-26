using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SakaryaBufe.Controllers
{
    public class HomeController : Controller
    {
        SakaryaBufe.SakaryaBufeEntities3 db = new SakaryaBufeEntities3(); // Sınıf tanımlama
        public ActionResult Index()
        {
            
            return View();
        }
        public ActionResult Slider()
        {
            var sliders = db.Mansets.Where(x => x.id > 0);   // id si 0 dan buyuk degerleri getirmeye yarar (Bos deger dondurmesini engellemek için)
            return View(sliders);

        }
        public ActionResult KategoriGetir()
        {
            var kategorilerr = db.Kategorilers.Where(X => X.id > 0);  //Kategori id den boş deger dönerse kabul edilmemesi için
            return View(kategorilerr);
        }


    }
}