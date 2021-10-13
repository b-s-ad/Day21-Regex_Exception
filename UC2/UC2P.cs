using System;
using System.Collections.Generic;
using System.Text;



namespace day21
{
    public class UC2P
    {
        public static string Regex_Last_name = "^[A-Z][a-z]{2}[ ]([A-Z][a-z]{2})$";
        public bool L_N(string last_name)
        {

            
                if (last_name == null)
                {
                    throw new URegCustomException(URegCustomException.ExceptionType.INVALID_MESSAGE, "Invalid Input");
                }
                return System.Text.RegularExpressions.Regex.IsMatch(last_name, Regex_Last_name);
            }
    }
    
}