using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeWars._4kyu;
namespace CodeWars.Tests
{
    [TestClass]
    public class StripCommentsTests
    {
        [TestMethod]
        public void StripComments_WhenGivenEmptyString_ReturnsExpected()
        {
            var expected = "";
            var actual = StripCommentsSolution.StripComments("", new string[] { "%", "$" });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StripComments_WhenGivenValidInput_ReturnsExpectedResult()
        {
            string stripped = StripCommentsSolution.StripComments("apples, pears # and bananas\ngrapes\nbananas !apples", new[] { "#", "!" });
            string result = "apples, pears\ngrapes\nbananas";

            Assert.AreEqual(stripped, result);
        }
    }
}
