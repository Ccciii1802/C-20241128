using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_01
{
    internal class Program01
    {
        static void Main()
        {
            string enteredUsername = "ADMIN";
            string storedUsername = "admin";
            if (string.Compare(enteredUsername, storedUsername, true) == 0)
            {
                Console.WriteLine("登入成功");
            }
            else
            {
                Console.WriteLine("登入失敗");
            }
            Console.ReadLine();

        }
    }
}
