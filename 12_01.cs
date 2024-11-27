using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_01
{
    internal class Program12
    {
        static void Main()
        {
            string email = "example.com";
            if (email.IndexOf('@') == -1)
            {
                Console.WriteLine("請輸入有效的電子郵件地址!");
            }
            Console.ReadLine();

        }
    }
}
