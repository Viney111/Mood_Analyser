using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mood_Analyser_Problem
{
    public class MoodAnalyser
    {
        #region Fields
        string message1;
        #endregion

        #region Constructor
        public MoodAnalyser(string message1)
        {
            this.message1 = message1;
        }
        public MoodAnalyser()
        {

        }
        #endregion

        #region Methods
        public string AnalysingMood()
        {
            try
            {
                if (this.message1.ToUpper().Equals(string.Empty))
                {
                    throw new MoodAnalysisException(ExceptionType.EMPTY_MESSAGE, "Message should not be empty");
                }
                if (this.message1.ToUpper().Contains("Happy".ToUpper()))
                {
                    return "Happy".ToUpper();
                }
                else
                {
                    return "Sad".ToUpper();
                }
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalysisException(ExceptionType.NULL_MESSAGE, "Message should not be null");
            }
        }
        public string AnalysingMood(string message)
        {
            try
            {
                if (message.ToUpper().Equals(string.Empty))
                {
                    throw new MoodAnalysisException(ExceptionType.EMPTY_MESSAGE, "Message should not be empty");
                }
                if (message.ToUpper().Contains("Happy".ToUpper()))
                {
                    return "Happy".ToUpper();
                }
                else
                {
                    return "Sad".ToUpper();
                }
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalysisException(ExceptionType.NULL_MESSAGE, "Message should not be null");
            }
        }
        #endregion
    }
}

