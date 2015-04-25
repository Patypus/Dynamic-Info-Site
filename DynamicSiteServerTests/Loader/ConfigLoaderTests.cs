using DynamicSiteServer.Loader;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicSiteServerTests.Loader
{
    [TestFixture]
    public class ConfigLoaderTests
    {
        private ConfigLoader _loader;

        [TestFixtureSetUp]
        public void Setup()
        {
            _loader = new ConfigLoader();
        }

        [Test]
        public void LoadConfigFile_LoadsCorrectBasicDataFromTestDataFile()
        {
            var pathToLoad = @"../../Loader/TestData/TestConfig.xml";
            var loadedConfig = _loader.LoadConfig(pathToLoad);

            Assert.AreEqual("Site's Name", loadedConfig.SiteName);
            Assert.AreEqual("Author's Name", loadedConfig.Author);
        }
    }
}
