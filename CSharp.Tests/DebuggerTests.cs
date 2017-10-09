using CSharp.Debugging;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharp.Tests
{
    [TestClass]
    public class DebuggerTests
    {
        [TestMethod]
        public void TestPersonWithDebuggerDisplay()
        {
            // set breakpoint on the next line to view the DebuggerDisplay functionality
            var person = new PersonWithDebuggerDisplay("Danny", 29);
        }
    }
}
