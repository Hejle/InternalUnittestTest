using System;

namespace InternalUnittestTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (args == null) throw new ArgumentNullException(nameof(args));

            Console.WriteLine("Main Method");
        }
    }
}