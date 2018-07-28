using CodeWars._6kyu;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars.Tests._6kyu
{
    [TestClass]
    public class BalancedParenthesisTests
    {
        [TestMethod]
        public void IsBalanced_WhenGivenBalancedInput_ReturnsTrue()
        {
            var testValue = "public void DoStuff(){ // stuff }";

            var actual = BalancedSymbols.IsBalanced(testValue);
            Assert.IsTrue(actual);
        }

        [DataRow("[)]", false)]
        [DataRow("public void DoStuff(){ // stuff }}", false)]
        [TestMethod]
        public void IsBalanced_WhenGivenUnbalancedInput_ReturnsFalse(string test, bool result)
        {
            

            var actual = BalancedSymbols.IsBalanced(test);
            Assert.AreEqual(result, actual);
        }
    }
}
