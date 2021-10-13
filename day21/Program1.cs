using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace day21
{
    class Program1
    {
        public static void Main(string[] args)
        {
            
            UC1P pattern = new UC1P(); // Regex Pattern
            
            Write("\tUC1 First Name\n");
             
            WriteLine(pattern.F_N("Abc"));
            
            ReadLine();
            
        }
    }
}