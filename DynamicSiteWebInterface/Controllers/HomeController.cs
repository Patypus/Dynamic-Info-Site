using DynamicSite.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace DynamicSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult SimplePage()
        {
            var model = GetBasicTestModel();

            return View(model);
        }

        private SimplePageModel GetBasicTestModel()
        {
            return new SimplePageModel
            {
                Title = "Test title",
                Leader = "Lead paragraph",
                Paragraphs = new List<string> { "para 1", "para 2" }
            };
        }
    }
}