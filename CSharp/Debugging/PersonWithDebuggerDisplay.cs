using System.Diagnostics;

namespace CSharp.Debugging
{
    /// <summary>
    /// A neat trick for debugging is to use the DebuggerDisplay attribute. 
    /// 
    /// You can apply it class level or property level to display a custom message when debugging. 
    /// Could provide value if working with complex data. Does introduce overhead. ToString() will override 
    /// this.
    /// </summary>

    [DebuggerDisplay("This person is named {Name} and is {AgeInYears} old")]
    public class PersonWithDebuggerDisplay
    {
        public string Name { get; set; }
        public int AgeInYears { get; set; }

        public PersonWithDebuggerDisplay(string name, int years)
        {
            Name = name;
            AgeInYears = years;
        }
    }

    public class PersonWithoutDebuggerDisplay
    {
        public string Name { get; set; }
        public int AgeInYears { get; set; }

        public PersonWithoutDebuggerDisplay(string name, int years)
        {
            Name = name;
            AgeInYears = years;
        }
    }
}
