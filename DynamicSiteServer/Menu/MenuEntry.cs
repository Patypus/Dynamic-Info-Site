using DynamicSiteServer.PageType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DynamicSiteServer.Menu
{
    /// <summary>
    /// Model For a single entry in site menu
    /// </summary>
    public class MenuEntry
    {
        /// <summary>
        /// Type indicating the type of page view to load. This is translated into a controller method name.
        /// </summary>
        public PageTypeEnum PageType { get; set; }

        /// <summary>
        /// Id for the page to load
        /// </summary>
        public string PageId { get; set; }
    }
}