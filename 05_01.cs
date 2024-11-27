using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_01
{
    internal class Program5
    {
        static void Main()
        {
            // 提示用戶輸入命令
            Console.WriteLine("請輸入命令：");
            string command = Console.ReadLine(); // 讀取用戶輸入

            // 檢查命令是否以 "Pro" 開頭
            if (command.StartsWith("Pro"))
            {
                Console.WriteLine($"命令 \"{command}\" 是有效的專業版命令。");
            }
            else
            {
                Console.WriteLine($"命令 \"{command}\" 無效，請確認是否以 \"Pro\" 開頭。");
            }

            Console.ReadLine();
        }
    }
}
