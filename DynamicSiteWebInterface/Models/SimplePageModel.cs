using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DynamicSite.Models
{
    /// <summary>
    /// Model for simple pages in the site
    /// </summary>
    public class SimplePageModel
    {
        /// <summary>
        /// Page title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Leader section for the page. Will be used for lower numbers header tags
        /// </summary>
        public string Leader { get; set; }

        /// <summary>
        /// Collection of strings which populate parahraphs. Each entry becomes a different paragraph.
        /// </summary>
        public IList<string> Paragraphs { get; set; }
    }
}