using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Nager.AmazonProductAdvertising.UnitTest
{
    [TestClass]
    public class AmazonResourceValidatorTest
    {
        [TestMethod]
        public void CheckValidator1()
        {
            var validator = new AmazonResourceValidator();
            var successful = validator.IsResourcesValid(new[] { "Images.Primary.Small" }, "SearchItems");
            Assert.IsTrue(successful);
        }

        [TestMethod]
        public void CheckValidator2()
        {
            var validator = new AmazonResourceValidator();
            var successful = validator.IsResourcesValid(new[] { "Images.Primary.Small", "Images.Primary.Medium" }, "SearchItems");
            Assert.IsTrue(successful);
        }

        [TestMethod]
        public void CheckValidator3()
        {
            var validator = new AmazonResourceValidator();
            var successful = validator.IsResourcesValid(new[] { "BrowseNodes.Ancestor" }, "SearchItems");
            Assert.IsFalse(successful);
        }
    }
}
