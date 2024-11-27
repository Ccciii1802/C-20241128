using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_01
{
    internal class Program4
    {
        static void Main()
        {
            Console.WriteLine("請輸入一種水果");

            // 原始水果名稱
            string fruit = Console.ReadLine();

            // 複製字串
            string copiedFruit = string.Copy(fruit);

            // 輸出複製的字串
            Console.WriteLine($"複製的水果名稱：{copiedFruit}");
            Console.ReadLine();
        }
    }
}
