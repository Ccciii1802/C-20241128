﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_01
{
    internal class Program
    {
        static void Main()
        {
            string str = "Good Morning";
            str=str.Replace("Morning", "Evening");
            Console.WriteLine(str);
            Console.ReadLine();
            
        }
    }
}
