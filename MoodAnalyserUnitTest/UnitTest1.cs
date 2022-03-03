using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mood_Analyser_Problem;

namespace MoodAnalyserUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivingSadMessage_RetunsSad()
        {
            //Arrange
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            //ACT
            string result = moodAnalyser.AnalysingMood("I am in Sad mood");
            //Assert
            Assert.AreEqual("SAD", result);
        }
        [TestMethod]
        public void GivingAnyMoodMessage_RetunsHappy()
        {
            //Arrange
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            //ACT
            string result = moodAnalyser.AnalysingMood("I am in any mood");
            //Assert
            Assert.AreEqual("HAPPY", result);
        }
    }

}
