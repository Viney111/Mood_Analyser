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
            if (this.message1.ToUpper().Contains("Happy".ToUpper()))
            {
                return "Happy".ToUpper();
            }
            if (this.message1.ToUpper().Contains("sad".ToUpper()))
            {
                return "Sad".ToUpper();
            }
            else
            {
                return "Null";
            }
        }
    }
}
