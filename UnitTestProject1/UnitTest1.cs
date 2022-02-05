using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser;
using System;

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

            //giving string value to message
            string message = "I am in Happy mood";
            //giving expected result to variable
            string expected = "happy";
            MoodAnalyser1 moodAnalyser = new MoodAnalyser1(message);

            //Act
            string actual = moodAnalyser.AnalyseMood();

            //Assert
            //comparing expected and actual values
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [TestCategory("Sad Mood")]
        public void GivenSadMessageReturnSadMood()
        {
            ///AAA Methodology
            ///Arrange

            //giving string value to message
            string message = "I am in Sad mood";
            //giving expected result to variable
            string expected = "sad";
            MoodAnalyser1 moodAnalyser = new MoodAnalyser1(message);

            //Act
            string actual = moodAnalyser.AnalyseMood();

            //Assert
            //comparing expected and actual values
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [TestCategory("Null case")]
        public void GivenNullMessageReturnHappyMood()
        {
            ///AAA Methodology
            ///Arrange
            //giving string value to message
            string message = null;
            //giving expected result to variable
            string expected = "happy";
            MoodAnalyser1 moodAnalyser = new MoodAnalyser1(message);

            //Act
            string actual = moodAnalyser.AnalyseMood();

            //Assert
            //comparing expected and actual values
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [TestCategory("Custom Exceptions")]
        public void GivenNullMessageReturnCustomException()
        {
            ///AAA Methodology
            ///Arrange
            //giving string value to message
            string message = null;
            //giving expected result to variable
            string expected = "message should not be null";
            try
            {
                MoodAnalyser1 moodAnalyser = new MoodAnalyser1(message);

                //Act
                string actual = moodAnalyser.AnalyseMood();
            }
            catch (CustomMoodAnalyserException ex)
            {
                //Assert
                //comparing expected and actual values
                Console.WriteLine("Custom: "+ex);
                Assert.AreEqual(expected, ex.Message);
            }
            catch (Exception ex)
            {
                //Assert
                //comparing expected and actual values
                Console.WriteLine("Custom: "+ex);
                Assert.AreEqual(expected, ex.Message);
            }
        }
        [TestMethod]
        [TestCategory("Custom Exceptions")]
        public void GivenEmptyMessageReturnCustomException()
        {
            ///AAA Methodology
            ///Arrange
            //giving string value to message
            string message = " ";
            //giving expected result to variable
            string expected = "message should not be empty";
            try
            {
                MoodAnalyser1 moodAnalyser = new MoodAnalyser1(message);

                //Act
                string actual = moodAnalyser.AnalyseMood();
            }
            catch (CustomMoodAnalyserException ex)
            {
                //Assert
                //comparing expected and actual values
                Console.WriteLine("Custom: "+ex);
                Assert.AreEqual(expected, ex.Message);
            }
            catch (Exception ex)
            {
                //Assert
                //comparing expected and actual values
                Console.WriteLine("Custom: "+ex);
                Assert.AreEqual(expected, ex.Message);
            }
        }
    }
}
