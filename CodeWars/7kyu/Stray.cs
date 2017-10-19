using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWars._7kyu
{
    public class Stray
    {
        public static int FindTheStray(int[] numbers)
        {
            var distinct =
                from g in numbers.GroupBy(x => x)
                where g.Count() == 1
                select g.First();

            var myVar = distinct.FirstOrDefault();
            return myVar;
        }
    }
}
