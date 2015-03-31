using DynamicSite.Models;
using DynamicSiteServer.Menu;
using DynamicSiteServer.PageType;
using System.Collections.Generic;
using System.Web.Mvc;

namespace DynamicSiteWebInterface.Controllers
{
    public class MainMenuController : Controller
    {
        public ActionResult Menu()
        {
            var menuModel = new MenuModel
            {
                MenuEntries = new List<MenuEntry>
                {
                    new MenuEntry { PageId = "Page1", PageType = PageTypeEnum.Simple },
                    new MenuEntry { PageId = "Page2", PageType = PageTypeEnum.Simple },
                    new MenuEntry { PageId = "Page3", PageType = PageTypeEnum.Simple }
                }
            };
            return PartialView("MainMenu", menuModel);
        }
    }
}