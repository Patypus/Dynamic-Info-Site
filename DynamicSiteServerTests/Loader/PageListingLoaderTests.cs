using DynamicSiteServer.Loader;
using DynamicSiteServer.PageType;
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
            var pathToLoad = @"../../Loader/TestData/SingleListing.xml";
            var result = _loader.LoadPageListing(pathToLoad).ToList();

            Assert.AreEqual(1, result.Count());
            var singleItem = result.First();
            Assert.AreEqual("TitleOne", singleItem.PageTitle);
            Assert.AreEqual("SomeFilePath", singleItem.PageContentFile);
            Assert.AreEqual(PageTypeEnum.Simple, singleItem.PageType);
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
