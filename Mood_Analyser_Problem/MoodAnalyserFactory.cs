using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Mood_Analyser_Problem
{
    
    public class MoodAnalyserFactory
    {  
        public static object CreateMoodAnalyserObject(string className, string Constructor)
        {
            string[] findingConstructorFromClassName = className.Split('.');
            if (findingConstructorFromClassName[1] == Constructor)
            {
                try
                {
                    Assembly assembly = Assembly.GetExecutingAssembly();
                    Type moodAnalyserType = Type.GetType(className);
                    var resultant = Activator.CreateInstance(moodAnalyserType);
                    return resultant;
                }
                catch
                {
                    throw new MoodAnalysisException(ExceptionType.NO_SUCH_CLASS_FOUND, "No such class found");
                }
            }
            else
            {
                throw new MoodAnalysisException(ExceptionType.NO_SUCH_METHOD_ERROR, "No such Method Error");
            }

        }
    }
}
