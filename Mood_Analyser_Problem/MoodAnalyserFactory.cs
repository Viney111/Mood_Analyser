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
        #region Method for Creating object of Parameterized Constructor
        public static object CreateMoodAnalyserObjectParameterizedConstructor(string className, string constructorName, string message)
        {
            string[] findingConstructorFromClassName = className.Split('.');
            if (findingConstructorFromClassName[1] == constructorName)
            {
                try
                {
                    Assembly assembly = Assembly.GetExecutingAssembly();
                    Type moodAnalyserType = assembly.GetType(className);
                    object[] args = { message };
                    object resultant = Activator.CreateInstance(moodAnalyserType,args);
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
        #endregion

        #region Method for Creating object of ParameterLess Constructor
        public static object CreateMoodAnalyserObjectWithParameterlessConstructor(string className, string Constructor)
        {
            string[] findingConstructorFromClassName = className.Split('.');
            if (findingConstructorFromClassName[1] == Constructor)
            {
                try
                {
                    Assembly assembly = Assembly.GetExecutingAssembly();
                    Type moodAnalyserType = assembly.GetType(className);
                    object resultant = Activator.CreateInstance(moodAnalyserType);
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
        #endregion
    }
}
