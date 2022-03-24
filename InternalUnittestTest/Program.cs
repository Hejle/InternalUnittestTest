using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternalUnittestTest
{
    public class Program
    {
        public static void Main(String[] args)
        {
            if (args == null) throw new ArgumentNullException(nameof(args));

            Console.WriteLine("Main Method");
        }
    }
}
