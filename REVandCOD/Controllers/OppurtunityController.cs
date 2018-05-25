using REVandCOD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace REVandCOD.Controllers
{
    public class OppurtunityController : Controller
    {
        // GET: Oppurtunity
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NewOpp()
        {
            Oppurtunity oppur = new Oppurtunity()
            {
                AccountName="Sudarson"
            };

            return View(oppur);
        }
    }
}