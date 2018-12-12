using System;
using System.Text;

namespace CSharp.Polymorphism.DoubleDispatch
{
    /// <summary>
    /// https://ardalis.com/double-dispatch-in-c-and-ddd
    /// </summary>
    public class SingleDispatch
    {
        public class Pen {

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
                _stringBuilder.AppendLine("Figure drawn in pen.");
            }

            public void Draw(Object something)
            {
                _stringBuilder.AppendLine("Figure drawn with something.");
            }
        }

    }
}
