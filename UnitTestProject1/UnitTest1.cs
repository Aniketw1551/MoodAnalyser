using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MoodAnalyser;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [TestCategory("Happy Mood")]
        public void GivenHappyMessageReturnHappyMood()
        {
            ///AAA Methodology
            ///Arrange
            string message = "I am in Happy mood";
            string expected = "happy";
            MoodAnalyser1 moodAnalyser = new MoodAnalyser1(message);

            //Act
            string actual = moodAnalyser.AnalyseMood();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("Sad Mood")]
        public void GivenSadMessageReturnSadMood()
        {
            ///AAA Methodology
            ///Arrange
            string message = "I am in Sad mood";
            string expected = "sad";
            MoodAnalyser1 moodAnalyser = new MoodAnalyser1(message);

            //Act
            string actual = moodAnalyser.AnalyseMood();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
