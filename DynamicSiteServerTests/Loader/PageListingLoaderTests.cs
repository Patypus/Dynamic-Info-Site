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
    public class PageListingLoaderTests
    {
        private PageListingLoader _loader;

        [TestFixtureSetUp]
        public void Setup()
        {
            _loader = new PageListingLoader();
        }

        [Test]
        public void LoadPageListing_SinglePageDetailsLoadedFromConfigFile()
        {
            Assert.Fail();
        }

        [Test]
        public void LoadPageListing_AllPageDetailsLoadedFromConfigFile()
        {
            Assert.Fail();
        }

        [Test]
        public void LoadPageListing_FileNotFoundExceptionWhenPageListingFileIsMissing()
        {
            Assert.Fail();
        }
    }
}
