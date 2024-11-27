using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_01
{
    internal class Program09
    {
        static void Main()
        {
            string phoneNumber = "1234567890";
            phoneNumber = phoneNumber.Insert(3, "-").Insert(7, "-");
            Console.WriteLine(phoneNumber);
            Console.ReadLine();

        }
    }
}
