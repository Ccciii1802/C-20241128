using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_01
{
    internal class Program18
    {
        static void Main()
        {
            string idNumber = "09-xx-xx-x062";
            string birthData = idNumber.Substring(10, 3);
            Console.WriteLine(birthData);
            Console.ReadLine();

        }
    }
}
