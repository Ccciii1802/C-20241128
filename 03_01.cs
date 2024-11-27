using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_01
{
    internal class Program3
    {
        static void Main()
        {
            // 提示用戶輸入名字
            Console.WriteLine("請輸入您的名字：");
            string name = Console.ReadLine(); // 讀取用戶輸入

            // 將名字轉換為大寫
            string upperName = name.ToUpper();

            // 顯示歡迎訊息
            Console.WriteLine($"歡迎您，{upperName}!");
            Console.ReadLine();
        }
    }
}
