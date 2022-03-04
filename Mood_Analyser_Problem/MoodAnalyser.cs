using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mood_Analyser_Problem
{
    public class MoodAnalyser
    {
        //Field for Comparing input message
        string message1;
        public MoodAnalyser(string message1)
        {
            this.message1 = message1;
        }
        public string AnalysingMood()
        {
            try
            {
                if (this.message1.ToUpper().Equals(string.Empty))
                {
                    throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.EMPTY_MESSAGE, "Message should not be empty");
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
                throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NULL_MESSAGE, "Message should not be null");
            }
        }
    }
}
