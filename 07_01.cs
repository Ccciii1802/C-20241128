using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_01
{
    internal class Program07
    {
        static void Main()
        {
            string firstName = "John";
            string lastName = "Doe";
            string domain = "@example.com";

            string email = string.Concat(firstName, ".", lastName, domain);
            Console.WriteLine("使用者的電子郵件地址是" + email);
            Console.ReadLine();

        }
    }
}
