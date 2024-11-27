using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_01
{
    internal class Program08
    {
        static void Main()
        {
            string userInput = "Password123";
            string correctPassword = "password123";

            bool isPasswordCorrect = userInput.Equals(correctPassword, StringComparison.OrdinalIgnoreCase);

            if (isPasswordCorrect)
            {
                Console.WriteLine("密碼正確，登入成功!");
            }
            else
            {
                Console.WriteLine("密碼錯誤，請再試一次!");
            }
            Console.ReadLine();

        }
    }
}
