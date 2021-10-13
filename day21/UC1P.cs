using System;
using System.Collections.Generic;
using System.Text;



namespace day21
{
    public class UC1P
    {
        public static string Regex_First_name = "^[A-Z][a-z][a-z]$";
        public bool F_N(string first_name)
        {

            
                if (first_name == null)
                {
                    throw new URegCustomException(URegCustomException.ExceptionType.INVALID_MESSAGE, "Invalid Input");
                } 
                return System.Text.RegularExpressions.Regex.IsMatch(first_name, Regex_First_name);
            }
    }
    
}