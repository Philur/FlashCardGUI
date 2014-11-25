using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FlashCardsLibrary;

namespace FlashCardGUIUnittests
{
    [TestClass]
    public class FlashCardGUIUnittests
    {
        [TestMethod]
        public void SetPlayerName()
        {
            FlashCardsController TestOjbect = new FlashCardsController("a");

            TestOjbect.User = "kalle";

            Assert.AreEqual(TestOjbect.User, "kalle");
        }

        [TestMethod]
        public void SetPlayerNameFail()
        {
            FlashCardsController TestOjbect = new FlashCardsController("a");

            TestOjbect.User = "kalle";

            //TODO this TC is to break the TestOjbect chain
            //Assert.AreEqual(TestOjbect.User, "kallde");
            //REFACTOR this TC so that it works better
            Assert.AreNotEqual(TestOjbect.User, "kallde");
        }

        [TestMethod]
        public void SetPlayerNameLongname()
        {
            FlashCardsController TestOjbect = new FlashCardsController("a");

            TestOjbect.User = "kalle anka från Göteborg i Sverige, Europa, Jorden";

            Assert.AreEqual(TestOjbect.User, "kalle anka från Göteborg i Sverige, Europa, Jorden");
        }

        [TestMethod]
        public void SetPlayerNameShortname()
        {
            FlashCardsController TestOjbect = new FlashCardsController("a");

            TestOjbect.User = "T";

            Assert.AreEqual(TestOjbect.User, "T");
        }

        [TestMethod]
        public void SetPlayerNameWithFunnyCharacters()
        {
            FlashCardsController TestOjbect = new FlashCardsController("a");

            TestOjbect.User = "kalle % # ; =} * á le´ ä ' ~";

            Assert.AreEqual(TestOjbect.User, "kalle % # ; =} * á le´ ä ' ~");
        }

        [TestMethod]
        public void SetPlayerNameWithFunnyCharacters2()
        {
            FlashCardsController TestOjbect = new FlashCardsController("a");

            TestOjbect.User = "john*^`?=)(/&%¤#!½_AppDomain:;*ÄÅÖ";

            Assert.AreEqual(TestOjbect.User, "john*^`?=)(/&%¤#!½_AppDomain:;*ÄÅÖ");
        }

        [TestMethod]
        public void SetPlayerNameWithFunnyCharacters3()
        {
            FlashCardsController TestOjbect = new FlashCardsController("a");

            TestOjbect.User = "'";

            Assert.AreEqual(TestOjbect.User, "'");
        }

        [TestMethod]
        public void SetNumber1()
        {
            FlashCardsController TestOjbect = new FlashCardsController("a");

            TestOjbect.Number1 = 1;

            Assert.AreEqual(TestOjbect.Number1, 1);
        }

        [TestMethod]
        public void SetNumber2()
        {
            FlashCardsController TestOjbect = new FlashCardsController("a");

            TestOjbect.Number2 = 1;

            //Assert.AreNotEqual(TestOjbect.Number2, 1);
            Assert.AreEqual(TestOjbect.Number2, 1);
        }

        [TestMethod]
        public void WorkOnLetterA()
        {
            FlashCardsController TestOjbect = new FlashCardsController("a");

            Assert.AreEqual(TestOjbect.WorkOn, "A");

            TestOjbect.WorkOn = "A";

            Assert.AreEqual(TestOjbect.WorkOn, "A");
        }

        [TestMethod]
        public void WorkOnLetterS()
        {
            FlashCardsController TestOjbect = new FlashCardsController("s");

            Assert.AreEqual(TestOjbect.WorkOn, "S");

            TestOjbect.WorkOn = "S";

            Assert.AreEqual(TestOjbect.WorkOn, "S");
        }

        [TestMethod]
        public void WorkOnLetterM()
        {
            FlashCardsController TestOjbect = new FlashCardsController("m");

            Assert.AreEqual(TestOjbect.WorkOn, "M");
            
            TestOjbect.WorkOn = "M";

            Assert.AreEqual(TestOjbect.WorkOn, "M");
        }

        [TestMethod]
        public void WorkOnLetterD()
        {
            FlashCardsController TestOjbect = new FlashCardsController("d");

            Assert.AreEqual(TestOjbect.WorkOn, "D");

            TestOjbect.WorkOn = "D";

            Assert.AreEqual(TestOjbect.WorkOn, "D");
        }

        //TODO Fix UT for the exception. This still does not work because I (Erik) really do not understand it
        /*[TestMethod]
        public void WorkOnLetter_other()
        {
            FlashCardsController TestOjbect = new FlashCardsController("x");

            UnitTestOjbectAssertException.Equals(System.ArgumentException("Must enter Add, Subtract, Multiply or Divide")); 
            
            TestOjbect.WorkOn = "X";

            UnitTestOjbectAssertException.Equals(System.ArgumentException("Must enter Add, Subtract, Multiply or Divide"));
        }
         */

        //REFACTOR Understand how to do this!
        [TestMethod]
        public void SetNumber1Multiplication()
        {
            FlashCardsController TestOjbect = new FlashCardsController("m");

            Assert.AreEqual(TestOjbect.WorkOn, "M");

            TestOjbect.GenerateNumbers();

            Assert.IsTrue(TestOjbect.Number1 < 13);
            Assert.IsTrue(TestOjbect.Number1 > 0);

        }

        [TestMethod]
        public void SetNumber2Multiplication()
        {
            FlashCardsController TestOjbect = new FlashCardsController("m");

            Assert.AreEqual(TestOjbect.WorkOn, "M");

            TestOjbect.GenerateNumbers();

            Assert.IsTrue(TestOjbect.Number2 < 13);
            Assert.IsTrue(TestOjbect.Number2 > 0);
        }

        [TestMethod]
        public void SetNumber1Division()
        {
            FlashCardsController TestOjbect = new FlashCardsController("d");

            Assert.AreEqual(TestOjbect.WorkOn, "D");

            TestOjbect.GenerateNumbers();

            Assert.IsTrue(TestOjbect.Number1 < 82);
            Assert.IsTrue(TestOjbect.Number1 > 0);
        }

        [TestMethod]
        public void SetNumber2Division()
        {
            FlashCardsController TestOjbect = new FlashCardsController("d");

            Assert.AreEqual(TestOjbect.WorkOn, "D");

            TestOjbect.GenerateNumbers();

            Assert.IsTrue(TestOjbect.Number2 < 10);
            Assert.IsTrue(TestOjbect.Number2 > 0);
        }

        [TestMethod]
        public void GetAndSetTries()
        {
            FlashCardsController TestOjbect = new FlashCardsController("a");

            Assert.AreEqual(TestOjbect.Tries, 0);

            TestOjbect.Number1 = 50;
            TestOjbect.Number2 = 5;

            TestOjbect.CheckAnswer(55);

            Assert.AreEqual(TestOjbect.Tries, 1);
        }

        [TestMethod]
        public void GetAndSetCorrectAddition()
        {
            FlashCardsController TestOjbect = new FlashCardsController("a");

            Assert.AreEqual(TestOjbect.Correct, 0);

            TestOjbect.Number1 = 50;
            TestOjbect.Number2 = 5;

            TestOjbect.CheckAnswer(55);

            Assert.AreEqual(TestOjbect.Correct, 1);
        }

        [TestMethod]
        public void GetAndSetCorrectSubtraction()
        {
            FlashCardsController TestOjbect = new FlashCardsController("s");

            Assert.AreEqual(TestOjbect.Correct, 0);

            TestOjbect.Number1 = 50;
            TestOjbect.Number2 = 5;

            TestOjbect.CheckAnswer(45);

            Assert.AreEqual(TestOjbect.Correct, 1);
        }

        [TestMethod]
        public void GetAndSetCorrectMultiplication()
        {
            FlashCardsController TestOjbect = new FlashCardsController("m");

            Assert.AreEqual(TestOjbect.Correct, 0);

            TestOjbect.Number1 = 50;
            TestOjbect.Number2 = 5;

            TestOjbect.CheckAnswer(250);

            Assert.AreEqual(TestOjbect.Correct, 1);
        }

        [TestMethod]
        public void GetAndSetCorrectDivision()
        {
            FlashCardsController TestOjbect = new FlashCardsController("d");

            Assert.AreEqual(TestOjbect.Correct, 0);

            TestOjbect.Number1 = 50;
            TestOjbect.Number2 = 5;

            TestOjbect.CheckAnswer(10);

            Assert.AreEqual(TestOjbect.Correct, 1);
        }

        [TestMethod]
        public void GetAndSetScoreAddition()
        {
            FlashCardsController TestOjbect = new FlashCardsController("a");

            Assert.AreEqual(TestOjbect.Score, 0);

            TestOjbect.Number1 = 50;
            TestOjbect.Number2 = 5;

            TestOjbect.CheckAnswer(55);

            Assert.AreEqual(TestOjbect.Score, 10);
        }

        [TestMethod]
        public void GetAndSetScoreSubtraction()
        {
            FlashCardsController TestOjbect = new FlashCardsController("s");

            Assert.AreEqual(TestOjbect.Score, 0);

            TestOjbect.Number1 = 50;
            TestOjbect.Number2 = 5;

            TestOjbect.CheckAnswer(45);

            Assert.AreEqual(TestOjbect.Score, 10);
        }

        [TestMethod]
        public void GetAndSetScoreMultiplication()
        {
            FlashCardsController TestOjbect = new FlashCardsController("m");

            Assert.AreEqual(TestOjbect.Score, 0);

            TestOjbect.Number1 = 50;
            TestOjbect.Number2 = 5;

            TestOjbect.CheckAnswer(250);

            Assert.AreEqual(TestOjbect.Score, 10);
        }

        [TestMethod]
        public void GetAndSetScoreDivision()
        {
            FlashCardsController TestOjbect = new FlashCardsController("d");

            Assert.AreEqual(TestOjbect.Score, 0);

            TestOjbect.Number1 = 50;
            TestOjbect.Number2 = 5;

            TestOjbect.CheckAnswer(10);

            Assert.AreEqual(TestOjbect.Score, 10);
        }

        [TestMethod]
        public void GetAndSetCorrectFail()
        {
            FlashCardsController TestOjbect = new FlashCardsController("a");

            Assert.AreEqual(TestOjbect.Correct, 0);

            TestOjbect.Number1 = 50;
            TestOjbect.Number2 = 0;

            TestOjbect.CheckAnswer(55);

            Assert.AreEqual(TestOjbect.Correct, 0);
        }

        [TestMethod]
        public void GetAndSetScoreFail()
        {
            FlashCardsController TestOjbect = new FlashCardsController("a");

            Assert.AreEqual(TestOjbect.Score, 0);

            TestOjbect.Number1 = 50;
            TestOjbect.Number2 = 0;

            TestOjbect.CheckAnswer(55);
            
            Assert.AreEqual(TestOjbect.Score, 0);
        }

        [TestMethod]
        public void CheckAnswerTrueDivision()
        {
            FlashCardsController TestOjbect = new FlashCardsController("d");

            TestOjbect.Number1 = 50;
            TestOjbect.Number2 = 5;

            Assert.IsTrue(TestOjbect.CheckAnswer(10));
        }

        [TestMethod]
        public void CheckAnswerTrueAddition()
        {
            FlashCardsController TestOjbect = new FlashCardsController("a");

            TestOjbect.Number1 = 50;
            TestOjbect.Number2 = 5;

            Assert.IsTrue(TestOjbect.CheckAnswer(55));
        }

        [TestMethod]
        public void CheckAnswerTrueSubtraction()
        {
            FlashCardsController TestOjbect = new FlashCardsController("s");

            TestOjbect.Number1 = 50;
            TestOjbect.Number2 = 5;

            Assert.IsTrue(TestOjbect.CheckAnswer(45));
        }

        [TestMethod]
        public void CheckAnswerTrueMultiplication()
        {
            FlashCardsController TestOjbect = new FlashCardsController("m");

            TestOjbect.Number1 = 50;
            TestOjbect.Number2 = 5;

            Assert.IsTrue(TestOjbect.CheckAnswer(250));
        }

        [TestMethod]
        public void CheckAnswerFalseAddition()
        {
            FlashCardsController TestOjbect = new FlashCardsController("a");

            TestOjbect.Number1 = 50;
            TestOjbect.Number2 = 0;

            Assert.IsFalse(TestOjbect.CheckAnswer(55));
        }

        [TestMethod]
        public void CheckAnswerFalseSubtraction()
        {
            FlashCardsController TestOjbect = new FlashCardsController("s");

            TestOjbect.Number1 = 50;
            TestOjbect.Number2 = 0;

            Assert.IsFalse(TestOjbect.CheckAnswer(45));
        }

        [TestMethod]
        public void CheckAnswerFalseMultiplication()
        {
            FlashCardsController TestOjbect = new FlashCardsController("m");

            TestOjbect.Number1 = 50;
            TestOjbect.Number2 = 4;

            Assert.IsFalse(TestOjbect.CheckAnswer(250));
        }

        [TestMethod]
        public void CheckAnswerFalseDivision()
        {
            FlashCardsController TestOjbect = new FlashCardsController("d");

            TestOjbect.Number1 = 50;
            TestOjbect.Number2 = 5;

            Assert.IsFalse(TestOjbect.CheckAnswer(11));
        }

        [TestMethod]
        public void BuildEquationAddition()
        {
            FlashCardsController TestOjbect = new FlashCardsController("a");

            TestOjbect.Number1 = 50;
            TestOjbect.Number2 = 5;

            Assert.AreEqual(TestOjbect.BuildEquation(), "50+5");      
        }
        [TestMethod]
        public void BuildEquationSubtraction()
        {
            FlashCardsController TestOjbect = new FlashCardsController("s");

            TestOjbect.Number1 = 50;
            TestOjbect.Number2 = 5;

            Assert.AreEqual(TestOjbect.BuildEquation(), "50-5");
        }

        [TestMethod]
        public void BuildEquationMultiplication()
        {
            FlashCardsController TestOjbect = new FlashCardsController("m");

            TestOjbect.Number1 = 50;
            TestOjbect.Number2 = 5;

            Assert.AreEqual(TestOjbect.BuildEquation(), "50*5");
        }

        [TestMethod]
        public void BuildEquationDivision()
        {
            FlashCardsController TestOjbect = new FlashCardsController("d");

            TestOjbect.Number1 = 50;
            TestOjbect.Number2 = 5;

            Assert.AreEqual(TestOjbect.BuildEquation(), "50/5");
        }

        //HACK this is a quite ugly test
        [TestMethod]
        public void TestNumberGenerator()
        {
            FlashCardsController TestOjbect = new FlashCardsController("a");

            TestOjbect.Number1 = 0;
            TestOjbect.Number2 = 0;

            Assert.AreEqual(TestOjbect.Number1, 0);
            Assert.AreEqual(TestOjbect.Number2, 0);

            NumberGenerator testNum = new NumberGenerator();

            testNum.GenerateNumbers(TestOjbect);

            Assert.AreNotEqual(TestOjbect.Number1, 0);
            Assert.AreNotEqual(TestOjbect.Number2, 0);
            Assert.IsTrue(TestOjbect.Number1 < 100);
            Assert.IsTrue(TestOjbect.Number2 < 100);
            Assert.IsTrue(TestOjbect.Number1 > 0);
            Assert.IsTrue(TestOjbect.Number2 > 0);
        }
    }
}
