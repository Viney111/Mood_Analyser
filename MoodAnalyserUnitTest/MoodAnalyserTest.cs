using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mood_Analyser_Problem;

namespace MoodAnalyserUnitTest
{
    [TestClass]
    public class MoodAnalyserTest
    {
        #region TestMethodsfor UC1 to UC3
        [TestMethod]
        public void GivingSadMessage_ReturnsSad()
        {
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            string result = moodAnalyser.AnalysingMood("I am in sad mood");
            Assert.AreEqual("SAD", result);
        }
        [TestMethod]
        public void GivingHappyMessage_RetunsHappy()
        {
            MoodAnalyser moodAnalyser = new MoodAnalyser("I am in happy mood");
            string result = moodAnalyser.AnalysingMood();
            Assert.AreEqual("HAPPY", result);
        }
        [TestMethod]
        public void GivingNULLMessage_ThrowsMoodAnalysisExceptionNullMessage()
        {
            try
            {
                MoodAnalyser moodAnalyser = new MoodAnalyser(null);
                string result = moodAnalyser.AnalysingMood();
            }
            catch (MoodAnalysisException ex)
            {
                Assert.AreEqual("Message should not be null", ex.Message);
            }
        }
        [TestMethod]
        public void GivingEMPTYMessage_ThrowsMoodAnalysisExceptionEmptyMessage()
        {
            try
            {
                MoodAnalyser moodAnalyser = new MoodAnalyser("");
                string result = moodAnalyser.AnalysingMood();
            }
            catch (MoodAnalysisException ex)
            {
                Assert.AreEqual("Message should not be empty", ex.Message);
            }
        }
        #endregion

        #region TestMethodsfor UC4
        [TestMethod]
        public void GivingClassNameProper_ReturnsMoodAnalyserObject_ParameterlessConstructor()
        {
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            object obj = MoodAnalyserFactory.CreateMoodAnalyserObjectWithParameterlessConstructor("Mood_Analyser_Problem.MoodAnalyser", "MoodAnalyser");
            Assert.AreEqual(moodAnalyser, obj);
        }
        [TestMethod]
        public void GivingClassNameImProper_ThrowsMoodAnalysisException_ParameterlessConstructor()
        {
            try
            {
                MoodAnalyser moodAnalyser = new MoodAnalyser();
                object obj = MoodAnalyserFactory.CreateMoodAnalyserObjectWithParameterlessConstructor("Mood_Analyser.MoodAnalyser", "MoodAnalyser");
            }
            catch (MoodAnalysisException ex)
            {
                Assert.AreEqual("No such class found", ex.Message);
            }
        }
        [TestMethod]
        public void GivingClassNameProperButConstructorNameImproper_ThrowsMoodAnalysisException_ParameterlessConstructor()
        {
            try
            {
                MoodAnalyser moodAnalyser = new MoodAnalyser();
                object obj = MoodAnalyserFactory.CreateMoodAnalyserObjectWithParameterlessConstructor("Mood_Analyser_Problem.MoodAnalyser", "MoodAnalysers");
            }
            catch (MoodAnalysisException ex)
            {
                Assert.AreEqual("No such Method Error", ex.Message);
            }
        }
        #endregion

        #region TestMethodsfor UC5
        [TestMethod]
        public void GivingClassNameProper_ReturnsMoodAnalyserObject_ParametrizedConstructor()
        {
            MoodAnalyser moodAnalyser = new MoodAnalyser("s");
            object obj = MoodAnalyserFactory.CreateMoodAnalyserObjectParameterizedConstructor("Mood_Analyser_Problem.MoodAnalyser", "MoodAnalyser");
            Assert.AreEqual(moodAnalyser, obj);
        }
        [TestMethod]
        public void GivingClassNameImProper_ThrowsMoodAnalysisException_ParametrizedConstructor()
        {
            try
            {
                MoodAnalyser moodAnalyser = new MoodAnalyser("s");
                object obj = MoodAnalyserFactory.CreateMoodAnalyserObjectParameterizedConstructor("Mood_Analyser.MoodAnalyser", "MoodAnalyser");
            }
            catch (MoodAnalysisException ex)
            {
                Assert.AreEqual("No such class found", ex.Message);
            }
        }
        [TestMethod]
        public void GivingClassNameProperButConstructorNameImproper_ThrowsMoodAnalysisException_ParametrizedConstructor()
        {
            try
            {
                MoodAnalyser moodAnalyser = new MoodAnalyser("s");
                object obj = MoodAnalyserFactory.CreateMoodAnalyserObjectParameterizedConstructor("Mood_Analyser_Problem.MoodAnalyser", "MoodAnalysers");
            }
            catch (MoodAnalysisException ex)
            {
                Assert.AreEqual("No such Method Error", ex.Message);
            }
        }
        #endregion
    }

}
