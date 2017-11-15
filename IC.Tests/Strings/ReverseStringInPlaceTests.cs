using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace IC.Tests.Strings
{
    [TestClass]
    public class ReverseStringInPlaceTests
    {
        [TestMethod]
        public void TestReverseStringInPlaceIsValid()
        {
            string name = "danny";
            name = name.ReverseStringInPlace();

            Assert.AreEqual("ynnad", name);
        }

        [TestMethod]
        public void TestReverseStringInPlaceIsValidWithOneCharacter()
        {
            string name = "d";
            name = name.ReverseStringInPlace();

            Assert.AreEqual("d", name);
        }

        [TestMethod]
        public void TestReverseStringInPlaceHasInvalidInput()
        {
            string name = null;
            name = name.ReverseStringInPlace();

            Assert.AreEqual("", name);
        }

        [TestMethod]
        public void TestReverseWordsInplaceHasValidInput()
        {
            string encodedMessage = "the eagle has landed";
            string decodedMessage = encodedMessage.ReverseSentenceInPlace();
            string expectedMessage = "landed has eagle the";

            Assert.AreEqual(expectedMessage, decodedMessage);
        }
    }
}
