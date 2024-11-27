using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_01
{
    internal class Program20
    {
        static void Main()
        {
            using (FileStream sourceStream = new FileStream("source.txt", FileMode.Open))
            using (FileStream destinationStream = new FileStream("destination.txt", FileMode.Create))
            {
                sourceStream.CopyTo(destinationStream);

            }
            Console.ReadLine();

        }
    }
}
