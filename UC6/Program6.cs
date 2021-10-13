using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace day21
{
    class Program6
    {
        public static void Main(string[] args)
        {
            
            UC6P pattern = new UC6P(); // Regex Pattern
            
            Write("\tUC6 Should have at least 1 Upper Case\n");
             
            WriteLine(pattern.UC_6("abcdA12@$"));
            
            ReadLine();
            
        }
    }
}