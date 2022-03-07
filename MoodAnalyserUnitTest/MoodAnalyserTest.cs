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
            object obj = MoodAnalyserReflector.CreateMoodAnalyserObjectWithParameterlessConstructor("Mood_Analyser_Problem.MoodAnalyser", "MoodAnalyser");
            moodAnalyser.Equals(obj);
        }
        [TestMethod]
        public void GivingClassNameImProper_ThrowsMoodAnalysisException_ParameterlessConstructor()
        {
            try
            {
                MoodAnalyser moodAnalyser = new MoodAnalyser();
                object obj = MoodAnalyserReflector.CreateMoodAnalyserObjectWithParameterlessConstructor("Mood_Analyser.MoodAnalyser", "MoodAnalyser");
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
                object obj = MoodAnalyserReflector.CreateMoodAnalyserObjectWithParameterlessConstructor("Mood_Analyser_Problem.MoodAnalyser", "MoodAnalysers");
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
            object obj = MoodAnalyserReflector.CreateMoodAnalyserObjectParameterizedConstructor("Mood_Analyser_Problem.MoodAnalyser", "MoodAnalyser", "Hi");
            moodAnalyser.Equals(obj);
        }
        [TestMethod]
        public void GivingClassNameImProper_ThrowsMoodAnalysisException_ParametrizedConstructor()
        {
            try
            {
                MoodAnalyser moodAnalyser = new MoodAnalyser("s");
                object obj = MoodAnalyserReflector.CreateMoodAnalyserObjectParameterizedConstructor("Mood_Analyser.MoodAnalyser", "MoodAnalyser", "Hi");
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
                object obj = MoodAnalyserReflector.CreateMoodAnalyserObjectParameterizedConstructor("Mood_Analyser_Problem.MoodAnalyser", "MoodAnalysers", "Hi");
            }
            catch (MoodAnalysisException ex)
            {
                Assert.AreEqual("No such Method Error", ex.Message);
            }
        }
        #endregion

        #region TestMethod for UC6
        [TestMethod]
        public void GivingMethodNameProperAndHappyMessage_InvokesMoodAnalyseMethodByReflection_ReturnsHappy()
        {
            try
            {
                MoodAnalyser moodAnalyser = new MoodAnalyser("Happy");
                string gettingOutputofMoodAnalyseMethodByReflection = MoodAnalyserReflector.InvokeMoodAnalyseMethod("AnalysingMood()", "Happy");
                Assert.AreEqual("Happy".ToUpper(), gettingOutputofMoodAnalyseMethodByReflection);
            }
            catch (MoodAnalysisException ex)
            {
                Assert.AreEqual("No such method is present in this class", ex.Message);
            }
        }
        [TestMethod]
        public void GivingMethodNameImProperAndHappyMessage_InvokesMoodAnalyseMethodByReflection_ThrowsMoodAnalysisException()
        {
            try
            {
                MoodAnalyser moodAnalyser = new MoodAnalyser("Happy");
                string gettingOutputofMoodAnalyseMethodByReflection = MoodAnalyserReflector.InvokeMoodAnalyseMethod("AnalysingMoods()", "Happy");
                Assert.AreEqual("Happy".ToUpper(), gettingOutputofMoodAnalyseMethodByReflection);
            }
            catch (MoodAnalysisException ex)
            {
                Assert.AreEqual("No such method is present in this class", ex.Message);
            }
        }
        #endregion

        #region TestMethod for UC7
        [TestMethod]
        public void GivingHappyMessage_SettingwithProperField_UsingReflection_ReturnHappy()
        {
            MoodAnalyserReflector reflector = new MoodAnalyserReflector();
            string value = "Happy";
            string fieldName = "message1";
            string resultant = "";
            resultant = MoodAnalyserReflector.SetField(value, fieldName);
            Assert.AreEqual("Happy", resultant);
        }
        [TestMethod]
        public void GivingHappyMessage_SettingwithImProperField_UsingReflection_ThrowNoSuchFieldException()
        {
            MoodAnalyserReflector reflector = new MoodAnalyserReflector();
            string value = "Happy";
            string fieldName = "between";
            string resultant = "";
            try
            {
                resultant = MoodAnalyserReflector.SetField(value, fieldName);
            }
            catch(System.Exception e)
            {
                Assert.AreEqual("Field name should not be null",e.Message);
            }
        }
        [TestMethod]
        public void GivingNullMessage_SettingwithProperField_UsingReflection_ThrowMessageShouldNotNullException()
        {
            MoodAnalyserReflector reflector = new MoodAnalyserReflector();
            string value = null;
            string fieldName = "message1";
            string resultant = "";
            try
            {
                resultant = MoodAnalyserReflector.SetField(value, fieldName);
            }
            catch (System.Exception e)
            {
                Assert.AreEqual("Message should not be null", e.Message);
            }
        }
        #endregion
    }
}
