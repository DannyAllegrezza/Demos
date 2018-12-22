using DesignPatterns.Builder;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatterns.Tests.Builder
{
    [TestClass]
    public class UrlBuilderTests
    {
        [TestMethod]
        public void UrlBuilder_ConstructsProperlyFormattedString()
        {
            var urlBuilder = new UrlBuilder();

            var finalUrl = urlBuilder
                        .WithBaseUri("www.test.com")
                        .WithQueryStringParam("name=john")
                        .WithQueryStringParam("name=danny")
                        .Create();

            var expected = "www.test.com?name=john&name=danny";

            Assert.AreEqual(expected, finalUrl);
        }
    }
}
