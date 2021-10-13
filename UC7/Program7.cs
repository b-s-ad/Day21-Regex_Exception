using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace day21
{
    class Program7
    {
        public static void Main(string[] args)
        {
            
            UC7P pattern = new UC7P(); // Regex Pattern

            Write("\tUC6 Should have at least 1 Numeric Number in the password\n");

            WriteLine(pattern.UC_7("1Abcde@#"));
            
            ReadLine();
            
        }
    }
}