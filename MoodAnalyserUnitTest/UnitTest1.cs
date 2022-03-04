using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mood_Analyser_Problem;

namespace MoodAnalyserUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivingSadMessage_ReturnsSad()
        {
            MoodAnalyser moodAnalyser = new MoodAnalyser("I am in sad mood");
            string result = moodAnalyser.AnalysingMood();
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
            catch(MoodAnalysisException ex)
            {
                Assert.AreEqual("Message should not be empty", ex.Message);
            }
        }
    }

}
