using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShop.Controllers
{
    public class AdminHomeController : Controller
    {
        //
        // GET: /home/

        public ActionResult Index()
        {
            return View();
        }

    }
}
