using DynamicSite.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace DynamicSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult MainPage()
        {
            var model = GetBasicTestModel("MainPage");

            return View("SimplePage", model);
        }

        public ActionResult SimplePage(string id)
        {
            var model = GetBasicTestModel(id);

            return View(model);
        }

        public ActionResult OtherPage(string id)
        {
            var model = GetBasicTestModel(id);

            return View(model);
        }

        private SimplePageModel GetBasicTestModel(string id)
        {
            return new SimplePageModel
            {
                Title = id,
                Leader = "Lead paragraph",
                Paragraphs = new List<string> { "para 1", "para 2" }
            };
        }
    }
}