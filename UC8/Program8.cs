using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace day21
{
    class Program8
    {
        public static void Main(string[] args)
        {

            UC8P pattern = new UC8P(); // Regex Pattern

            Write("\tUC6 Should have at least 1 Special Character\n");

            WriteLine(pattern.UC_8("Abc@123D"));
            
            ReadLine();
            
        }
    }
}