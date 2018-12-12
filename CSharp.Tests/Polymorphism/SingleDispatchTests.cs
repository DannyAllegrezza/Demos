using CSharp.Polymorphism.DoubleDispatch;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text;

namespace CSharp.Tests.Polymorphism
{
    [TestClass]
    public class SingleDispatchTests
    {
        [TestMethod]
        public void Single_Dispatch_Occurs_When_Using_Early_Binding()
        {
            var sb = new StringBuilder();
            var figure = new SingleDispatch.Figure(sb);

            figure.Draw(new SingleDispatch.Pen());

            // Even though this is a Pen class, at compile time, this variable is instead an object and thus uses the Draw(Object obj) overload
            object reallyAPen = new SingleDispatch.Pen();

            figure.Draw(reallyAPen);

            var result = sb.ToString();

            Assert.AreEqual(@"Figure drawn in pen." + Environment.NewLine +
                            "Figure drawn with something." + Environment.NewLine, result);
        }
    }
}
