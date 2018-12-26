
//using SakaryaBufe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SakaryaBufe.Controllers
{
    public class HakkımızdaController : Controller
    {
        SakaryaBufe.SakaryaBufeEntities3 db = new SakaryaBufeEntities3();

        // GET: Hakkımızda
        public ActionResult Hakkimizda()
        {
            return View();
        }
    }
}
