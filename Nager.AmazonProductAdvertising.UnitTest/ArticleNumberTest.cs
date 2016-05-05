using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nager.AmazonProductAdvertising.Helper;
using Nager.AmazonProductAdvertising.Model;

namespace Nager.AmazonProductAdvertising.UnitTest
{
    [TestClass]
    public class ArticleNumberTest
    {
        [TestMethod]
        public void TestIsAsin()
        {
            var isAsin = ArticleNumberHelper.IsValidAsin("B007KKKJYK");
            Assert.AreEqual(isAsin, true);
        }

        [TestMethod]
        public void TestIsIsbn()
        {
            var isIsbn10 = ArticleNumberHelper.IsValidIsbn("3551559015");
            Assert.AreEqual(isIsbn10, true);

            var isIsbn13 = ArticleNumberHelper.IsValidIsbn("978-3551559012");
            Assert.AreEqual(isIsbn13, true);
        }

        [TestMethod]
        public void TestIsGtin()
        {
            var isGtin = ArticleNumberHelper.IsValidGtin("4002515289693");
            Assert.AreEqual(isGtin, true);
        }

        [TestMethod]
        public void TestArtileNumberType()
        {
            var articleNumberType = ArticleNumberHelper.GetArticleNumberType("4002515289693");
            Assert.AreEqual(articleNumberType, ArticleNumberType.GTIN);

            articleNumberType = ArticleNumberHelper.GetArticleNumberType("978-3551559012");
            Assert.AreEqual(articleNumberType, ArticleNumberType.ISBN);

            articleNumberType = ArticleNumberHelper.GetArticleNumberType("B007KKKJYK");
            Assert.AreEqual(articleNumberType, ArticleNumberType.ASIN);

            articleNumberType = ArticleNumberHelper.GetArticleNumberType("test");
            Assert.AreEqual(articleNumberType, ArticleNumberType.ASIN);
        }
    }
}
