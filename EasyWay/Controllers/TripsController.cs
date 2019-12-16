using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EasyWay.Controllers
{
    public class TripsController : Controller
    {
        // GET: Trips
        public ActionResult New()
        {
            return View();
        }
    }
}