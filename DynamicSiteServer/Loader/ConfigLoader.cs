using DynamicSiteServer.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace DynamicSiteServer.Loader
{
    internal class ConfigLoader
    {
        internal SiteConfig LoadConfig(string configPath)
        {
            SiteConfig data;
            var serialiser = new XmlSerializer(typeof(SiteConfig));
            using (var reader = new StreamReader(configPath))
            {
                data = (SiteConfig) serialiser.Deserialize(reader);
            }
            
            return data;
        }
    }
}
