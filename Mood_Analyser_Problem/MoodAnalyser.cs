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
        string message1 = "Sad";
        public string AnalysingMood(string message)
        {
            if (message.ToUpper().Contains(message1.ToUpper()))
            {
                return message1.ToUpper();
            }
            else
            {
                return "Happy".ToUpper();
            }
        }
    }
}
