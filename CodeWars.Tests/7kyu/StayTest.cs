using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using CodeWars._7kyu;

namespace CodeWars.Tests._7kyu
{
    [TestClass]
    public class StayTest
    {
        [TestMethod]
        public void SimpleArray1()
        {
            Assert.AreEqual(2, Stray.FindTheStray(new int[] { 1, 1, 2 }));
        }
    }
}
