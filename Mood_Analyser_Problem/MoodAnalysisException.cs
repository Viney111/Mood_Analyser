using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mood_Analyser_Problem
{
    public class MoodAnalysisException : Exception
    {
        public enum ExceptionType
        {
            NULL_MESSAGE,EMPTY_MESSAGE
        }
        public ExceptionType Type;

        public MoodAnalysisException(ExceptionType type, string message) : base(message)
        {
            Type = type;
        }
    }
}
