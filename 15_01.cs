using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_01
{
    internal class Program15
    {
        static void Main()
        {
            string Name = "document.pdf";
            string NewName = Name.Remove(Name.LastIndexOf('.'));
            Console.WriteLine(NewName);
            Console.ReadLine();

        }
    }
}
