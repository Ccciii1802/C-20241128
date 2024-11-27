using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_01
{
    internal class Program14
    {
        static void Main()
        {
            string[] dataParts = { "2024", "11", "20" };
            string fullData = string.Join("-", dataParts);
            Console.WriteLine(fullData);
            Console.ReadLine();

        }
    }
}
