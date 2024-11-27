using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_01
{
    internal class Program02
    {
        static void Main()
        {
            string name1 = "Mary";
            string name2 = "Ted";

            int result = name1.CompareTo(name2);
            string output = result < 0 ? $"{name1}排在{name2}前面" : $"{name2}排在{name1}前面";
            Console.WriteLine(output);
            Console.ReadLine();

        }
    }
}
