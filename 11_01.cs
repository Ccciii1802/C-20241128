using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_01
{
    internal class Program11
    {
        static void Main()
        {
            string[] name = { "Alice", "Bob", "Charlie" };
            int[] scores = { 95, 88, 92 };

            Console.WriteLine("name".PadRight(15) + "Score");
            Console.WriteLine(new string('-', 25));
            for (int i = 0; i < scores.Length; i++)
            {
                Console.WriteLine(name[i].PadRight(15) + scores[i]);
            }
            Console.ReadLine();

        }
    }
}
