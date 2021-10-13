using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace day21
{
    class Program2
    {
        public static void Main(string[] args)
        {
            
            UC2P pattern = new UC2P(); // Regex Pattern
            
            Write("\tUC2 Last Name\n");
             
            WriteLine(pattern.L_N("Abc Abc"));
            
            ReadLine();
            
        }
    }
}