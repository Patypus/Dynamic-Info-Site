using DynamicSiteServer.Exceptions;
using DynamicSiteServer.Loader;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
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
            Assert.AreEqual(@"../../Loader/TestData/PageListingFile.xml", loadedConfig.MasterPageListing);
        }

        [Test, ExpectedException(typeof(FileNotFoundException))]
        public void LoadConfigFile_ThrowsFileNotFoundExceptionWhenFileDoesNotExist()
        {
            var pathToLoad = @"Z:/some/made/up/path.txt";
            _loader.LoadConfig(pathToLoad);
        }

        [Test, ExpectedException(typeof(FileNotFoundException))]
        public void LoadConfigFile_ThrowsFileNotFoundExceptionWhenListingFileInConfigDoesNotExist()
        {
            var pathToLoad = @"../../Loader/TestData/TestConfig_MissingListingFile.xml";
            var loadedConfig = _loader.LoadConfig(pathToLoad);
        }

        [Test, ExpectedException(typeof(MalformedConfigFileException))]
        public void LoadConfigFile_ThrowsMalformedConfigFileExceptionWhenFileIsMalformed()
        {
            var pathToLoad = @"../../Loader/TestData/InvalidConfig.xml";
            _loader.LoadConfig(pathToLoad);
        }
    }
}
