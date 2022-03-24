using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("InternalUnittestTestTests")]

namespace InternalUnittestTest
{
    public class Person
    {
        public string? Name { get; set; }

        public int Age { get; set; }

        internal int InternalAge { get; set; }
    }
}