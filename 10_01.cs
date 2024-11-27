using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_01
{
    internal class Program10
    {
        static void Main()
        {
            string employeeNumber = "42";
            string paddedNumber = employeeNumber.PadLeft(5);
            Console.WriteLine(paddedNumber);
            Console.ReadLine();

        }
    }
}
