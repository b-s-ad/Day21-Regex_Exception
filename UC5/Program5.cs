using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace day21
{
    class Program5
    {
        public static void Main(string[] args)
        {
            
            UC5P pattern = new UC5P(); // Regex Pattern
            
            Write("\tUC 5 : Minimum 8 Char \n");
             
            WriteLine(pattern.UC_5("AbCD12#$"));
            
            ReadLine();
            
        }
    }
}