using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_01
{
    internal class Program06
    {
        static void Main()
        {
            string fileName = "report.pdf";

            bool isPdf = fileName.EndsWith("pdf");

            if (isPdf)
            {
                Console.WriteLine($"{fileName}是PDF文件。");
            }
            else
            {
                Console.WriteLine($"{fileName}不是PDF文件。");
            }
            Console.ReadLine();

        }
    }
}
