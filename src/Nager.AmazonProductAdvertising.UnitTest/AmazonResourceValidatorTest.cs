using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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

        [TestMethod]
        public void CheckValidator4()
        {
            var validator = new AmazonResourceValidator();
            var successful = validator.IsResourcesValid(new string[0], "SearchItems");
            Assert.IsTrue(successful);
        }

        [TestMethod]
        public void CheckValidator5()
        {
            var validator = new AmazonResourceValidator();
            var successful = validator.IsResourcesValid(null, "SearchItems");
            Assert.IsFalse(successful);
        }

        [TestMethod]
        public void CheckValidator6()
        {
            var validator = new AmazonResourceValidator();
            var successful = validator.IsResourcesValid(new[] { "SearchRefinements" }, "GetItems");
            Assert.IsFalse(successful);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "operation")]
        public void CheckValidator7()
        {
            var validator = new AmazonResourceValidator();
            validator.IsResourcesValid(null, null);
        }
    }
}
