using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DynamicSiteWebInterface.Controllers
{
    public class LayoutController : Controller
    {
        public ActionResult MainLayout()
        {
            return View();
        }
    }
}