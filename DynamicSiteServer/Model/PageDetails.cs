using DynamicSiteServer.PageType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicSiteServer.Model
{
    /// <summary>
    /// Model class for the details of a single page in the site. The page listing config file contains a collection
    /// of PageDetails entries, one for each page in the site.
    /// </summary>
    public class PageDetails
    {
        public string PageTitle { get; set; }

        public string PageContentFile { get; set; }

        public PageTypeEnum PageType{ get; set; }
    }
}
