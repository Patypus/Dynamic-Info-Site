using DynamicSiteServer.Model;
using DynamicSiteServer.PageType;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace DynamicSiteServer.Loader
{
    internal class PageListingLoader
    {
        internal IEnumerable<PageDetails> LoadPageListing(string pageListingFile)
        {
            var document = XDocument.Load(pageListingFile);
            return document.Root.Elements().Select(e => new PageDetails
                                                        {
                                                            PageTitle = e.Element("PageTitle").Value,
                                                            PageContentFile = e.Element("PageContentFile").Value,
                                                            PageType = (PageTypeEnum)Enum.Parse(typeof(PageTypeEnum), e.Element("PageType").Value)
                                                        });
        }
    }
}
