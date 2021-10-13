using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace day21
{
    class Program4
    {
        public static void Main(string[] args)
        {
            
            UC4P pattern = new UC4P(); // Regex Pattern
            
            Write("\tUC 4 : Pre-defined Mobile Format \n");
             
            WriteLine(pattern.UC_4("91 9919819801"));
            
            ReadLine();
            
        }
    }
}