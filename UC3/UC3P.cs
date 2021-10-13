using System;
using System.Collections.Generic;
using System.Text;



namespace day21
{
    public class UC3P
    {
        public static string Regex_UC3 = "^[a-z][-a-z0-9._]+@([-a-z0-9{2,2}]+[.])+[a-z]{2,2}$";
        public bool UC_3(string input)
        {

            
                if (input == null)
                {
                    throw new URegCustomException(URegCustomException.ExceptionType.INVALID_MESSAGE, "Invalid Input");
                }
                return System.Text.RegularExpressions.Regex.IsMatch(input, Regex_UC3);
            }
    }
    
}