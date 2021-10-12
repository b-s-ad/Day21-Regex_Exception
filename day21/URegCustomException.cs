using System;
using System.Collections.Generic;
using System.Text;


namespace day21
{
    public class URegCustomException : Exception
    {
        
        public enum ExceptionType
        {
            INVALID_MESSAGE
        }
        public ExceptionType type;
        public URegCustomException(ExceptionType Type, String message) : base(message)
        {
            this.type = Type;

        }
    }
}
   