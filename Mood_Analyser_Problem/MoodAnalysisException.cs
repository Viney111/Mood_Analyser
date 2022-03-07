using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mood_Analyser_Problem
{
    #region enums
    public enum ExceptionType
    {
        NULL_MESSAGE, EMPTY_MESSAGE, NO_SUCH_CLASS_FOUND, NO_SUCH_METHOD_ERROR, FIELD_NOT_FOUND
    }
    #endregion
    public class MoodAnalysisException : Exception
    {
        #region Enum Field
        public ExceptionType Type;
        #endregion

        #region Constructor
        public MoodAnalysisException(ExceptionType type, string message) : base(message)
        {
            Type = type;
        }
        #endregion
    }
}
