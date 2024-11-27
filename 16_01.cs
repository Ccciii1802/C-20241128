using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_01
{
    internal class Program16
    {
        static void Main()
        {
            string userComment = "The product is great and the service is excellent";
            string[] words = userComment.Split(' ');
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
            Console.ReadLine();

        }
    }
}
