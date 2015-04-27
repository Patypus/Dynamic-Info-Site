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
    /// <summary>
    /// Class for loading site config files
    /// </summary>
    internal class ConfigLoader
    {
        /// <summary>
        /// Loads an xml config file as a SiteConfig object from the provided path.
        /// </summary>
        /// <param name="configPath">Path to the config file to load</param>
        /// <returns>SiteConfig object representing the details from the file at the provided path.</returns>
        internal SiteConfig LoadConfig(string configPath)
        {
            if (!File.Exists(configPath))
            {
                throw new FileNotFoundException(string.Format(Strings.MetaConfigFileNotFoundAtPath, configPath));
            }
            var deserialisedData = DeserialiseConfigFile(configPath);
            return CheckPageListingFilePath(deserialisedData);
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

        private SiteConfig CheckPageListingFilePath(SiteConfig loadedConfig)
        {
            if (!File.Exists(loadedConfig.MasterPageListing))
            {
                var message = String.Format(Strings.MissingListingFileFromMetaConfig, loadedConfig.MasterPageListing);
                throw new FileNotFoundException();
            }
            return loadedConfig;
        }
    }
}
