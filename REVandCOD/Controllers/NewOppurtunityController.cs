using REVandCOD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace REVandCOD.Controllers
{
    public class NewOppurtunityController : Controller
    {
        // GET: NewOppurtunity
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(NewOppurtunity newOppur)
        {
            return View();
        }

    }
}