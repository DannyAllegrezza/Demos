using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Tests.Polymorphism
{
    public abstract class Pen
    {
        public abstract void Draw(StringBuilder sb);
    }

    public class RedPen : Pen
    {
        public override void Draw(StringBuilder sb)
        {
            sb.Append("in red pen.");
        }
    }

    public class BlackPen : Pen
    {
        public override void Draw(StringBuilder sb)
        {
            sb.Append("in black pen.");
        }
    }

    public class Figure
    {
        private readonly StringBuilder _stringBuilder;

        public Figure(StringBuilder stringBuilder)
        {
            _stringBuilder = stringBuilder;
        }
        public void Draw(Pen pen)
        {
            _stringBuilder.Append("Figure drawn ");
            pen.Draw(_stringBuilder);
            _stringBuilder.AppendLine();
        }
    }

    [TestClass]
    public class DoubleDispatchTests
    {
        [TestMethod]
        public void Test()
        {
            var sb = new StringBuilder();
            var figure = new Figure(sb);
            // the runtime type is used to determine which method is called
            figure.Draw(new RedPen());
            figure.Draw(new BlackPen());

            var result = sb.ToString();

            Assert.AreEqual(@"Figure drawn in red pen." + Environment.NewLine +
                            "Figure drawn in black pen." + Environment.NewLine, result);

        }
    }
}
