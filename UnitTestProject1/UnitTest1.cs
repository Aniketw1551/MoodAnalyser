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
                Console.WriteLine("Custom: " + ex);
                Assert.AreEqual(expected, ex.Message);
            }
            catch (Exception ex)
            {
                //Assert
                //comparing expected and actual values
                Console.WriteLine("Custom: " + ex);
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
                Console.WriteLine("Custom: " + ex);
                Assert.AreEqual(expected, ex.Message);
            }
            catch (Exception ex)
            {
                //Assert
                //comparing expected and actual values
                Console.WriteLine("Custom: " + ex);
                Assert.AreEqual(expected, ex.Message);
            }
        }
        [TestMethod]
        [TestCategory("Invalid class Name")]
        public void GivenInvalidClassNameShouldThrowMoodAnalyserException()
        {
            ///AAA Methodology 

            //giving expected value to variable 
            string expected = "Class is not Found";
            try
            {
                //creating instence of class 
                object obj = MoodAnalyserFactory.CreateMoodAnalyseMethod("MoodAnalyser.MoodAnalyzer", "MoodAnalyzer");
            }
            catch (CustomMoodAnalyserException ex)
            {
                //comparing and catching exception
                Assert.AreEqual(expected, ex.Message);
            }
        }

        [TestMethod]
        [TestCategory("Invalid cunstructor")]
        public void GivenClassWhenInvalidConstructorShouldThrowMoodAnalyserException()
        {
            ///AAA Methodology 

            //giving expected value to variable 
            string expected = "Constructor is not Found";
            try
            {
                //creating instence of class 
                object obj = MoodAnalyserFactory.CreateMoodAnalyseMethod("MoodAnalyser.MoodAnalyzer", "MoodAnalyzer");
            }
            catch (CustomMoodAnalyserException ex)
            {
                //comparing and catching exception
                Assert.AreEqual(expected, ex.Message);
            }
        }
        //returns instance method
        [TestMethod]
        [TestCategory("Invalid cunstructor")]
        public void GivenMoodAnalyserRightReturnMoodAnalyseObject()
        {
            object expected = new MoodAnalyzer("HAPPY");
            object obj = MoodAnalyserFactory.CreatedMoodAnalyserUsingParameterizedConstructor("MoodAnalyser.MoodAnalyzer", "MoodAnalyzer", "HAPPY");
            expected.Equals(obj);
        }
        // Given Invalid class name should throw CustomMoodAnalyserException.
        [TestMethod]
        [TestCategory("class with invalid parameterised")]
        public void GivenInvalidClassName_ShouldThrow_MoodAnalyserException_Of_ParameterisedConstructor()
        {
            string expected = "Class not found";
            try
            {
                object obj = MoodAnalyserFactory.CreatedMoodAnalyserUsingParameterizedConstructor("MoodAnalyser.sampleClass", "MoodAnalyzer", "HAPPY");
            }
            catch (CustomMoodAnalyserException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
        // Given Invalid constructor name should throw CustomMoodAnalyserException        
        [TestMethod]
        [TestCategory("constructor with invalid parameterised")]
        public void GivenInvalidConstructorName_ShouldThrow_MoodAnalyserException_Of_ParameterizedConstructor()
        {
            string expected = "Constructor is not found";
            try
            {
                object obj = MoodAnalyserFactory.CreatedMoodAnalyserUsingParameterizedConstructor("MoodAnalyser.MoodAnalyzer", "sampleClass", "HAPPY");
            }
            catch (CustomMoodAnalyserException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
    }
}

