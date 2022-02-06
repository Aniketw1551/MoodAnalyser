using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class CustomMoodAnalyserException : Exception
    {
        //Exception type variable
        public ExceptionType type;

        //Using enum method 
        public enum ExceptionType
        {
            NULL_EXCEPTION,
            EMPTY_EXCEPTION,
            NO_SUCH_CLASS,
            NO_SUCH_METHOD,
            INVALID_INPUT
        }
        public CustomMoodAnalyserException(ExceptionType type, string message):base(message)
        {
            this.type = type;
        }
    }
}
