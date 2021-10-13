using System;
using System.Collections.Generic;
using System.Text;



namespace day21
{
    public class UC4P
    {
        public static string Regex_input = "^[9][1][ ][1-9][0-9]{9}$";
        public bool UC_4(string input)
        {

            
                if (input == null)
                {
                    throw new URegCustomException(URegCustomException.ExceptionType.INVALID_MESSAGE, "Invalid Input");
                }
                return System.Text.RegularExpressions.Regex.IsMatch(input, Regex_input);
            }
    }
    
}