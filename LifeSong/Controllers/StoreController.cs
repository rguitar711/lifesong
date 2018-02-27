using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LifeSong.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult Artist()
        {
            return View();

        }

        public ActionResult Story()
        {

            return View();
        }

        public ActionResult Steps()
        {
            return View();

        }
    }
}