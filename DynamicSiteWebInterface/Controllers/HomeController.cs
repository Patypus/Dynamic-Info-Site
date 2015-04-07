﻿using DynamicSite.Models;
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

        public ActionResult SimplePage(string pageId)
        {
            var model = GetBasicTestModel(pageId);

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