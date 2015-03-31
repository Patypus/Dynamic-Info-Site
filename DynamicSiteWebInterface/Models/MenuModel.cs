using DynamicSiteServer.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DynamicSite.Models
{
    /// <summary>
    /// Model for the main site menu
    /// </summary>
    public class MenuModel
    {
        /// <summary>
        /// Collection of menu model items which will be built into a strip menu.
        /// </summary>
        public IList<MenuEntry> MenuEntries { get; set; }
    }
}