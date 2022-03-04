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
            //Arrange
            MoodAnalyser moodAnalyser = new MoodAnalyser("I am in sad mood");
            //ACT
            string result = moodAnalyser.AnalysingMood();
            //Assert
            Assert.AreEqual("SAD", result);
        }
        [TestMethod]
        public void GivingHappyMessage_RetunsHappy()
        {
            //Arrange
            MoodAnalyser moodAnalyser = new MoodAnalyser("I am in happy mood");
            //ACT
            string result = moodAnalyser.AnalysingMood();
            //Assert
            Assert.AreEqual("HAPPY", result);
        }
        [TestMethod]
        public void GivingNULLMessage_RetunsHappy()
        {
            //Arrange
            MoodAnalyser moodAnalyser = new MoodAnalyser(null);
            //ACT
            string result = moodAnalyser.AnalysingMood();
            //Assert
            Assert.AreEqual("HAPPY", result);
        }
    }

}
