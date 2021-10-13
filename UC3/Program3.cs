using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace day21
{
    class Program3
    {
        public static void Main(string[] args)
        {
            
            UC3P pattern = new UC3P(); // Regex Pattern
            
            Write("\tUC : 3 Valid Email 3 mandatory | 2 optional parts \n");
             
            WriteLine(pattern.UC_3("abc.xyz@bl.co.in"));
            
            ReadLine();
            
        }
    }
}