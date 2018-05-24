using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using REVandCOD.Models;

namespace REVandCOD.Controllers
{
    public class NewOppurtunityController : Controller
    {
        NewOppurtunity oppur = new NewOppurtunity()
        {
            AccountName = "Npower"
        };
        // GET: NewOppurtunity
        public ActionResult NewOpp()
        {
            return View(oppur);
        }


    }
}