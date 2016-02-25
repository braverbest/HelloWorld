using Journey.Service.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Journey.Web.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            new HomeService().getOrder();
            return View();
        }

        public ActionResult Login() 
        {
            return View();
        }

    }
}
