using DynamicSiteServer.Exceptions;
using DynamicSiteServer.Model;
using DynamicSiteServer.Resources;
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
            if (!File.Exists(configPath))
            {
                throw new FileNotFoundException(string.Format(Strings.MetaConfigFileNotFoundAtPath, configPath));
            }
            return DeserialiseConfigFile(configPath);
        }

        private SiteConfig DeserialiseConfigFile(string configFilePath)
        {
            SiteConfig configData = null;
            try
            {
                var serialiser = new XmlSerializer(typeof(SiteConfig));
                using (var reader = new StreamReader(configFilePath))
                {
                    configData = (SiteConfig) serialiser.Deserialize(reader);
                }
            }
            catch (InvalidOperationException)
            {
                throw new MalformedConfigFileException(string.Format(Strings.UnableToLoadMetaConfigFile, configFilePath));
            }
            return configData;
        }
    }
}
