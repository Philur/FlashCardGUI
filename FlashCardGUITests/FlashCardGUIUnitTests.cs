using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FlashCardsLibrary;

namespace FlashCardGUIUnittests
{
    [TestClass]
    public class FlashCardGUIUnittests
    {
        //TODO Add more UnittestOBJ!!
        [TestMethod]
        public void SetPlayerName()
        {
            FlashCardsController testOBJ = new FlashCardsController("a");

            testOBJ.User = "kalle";

            Assert.AreEqual(testOBJ.User, "kalle");
        }

        [TestMethod]
        public void SetPlayerNameFail()
        {
            FlashCardsController testOBJ = new FlashCardsController("a");

            testOBJ.User = "kalle";

            //TODO this TC is to break the testOBJ chain
            //Assert.AreEqual(testOBJ.User, "kallde");
            //REFACTOR this TC so that it works better
            Assert.AreNotEqual(testOBJ.User, "kallde");
        }

        [TestMethod]
        public void SetPlayerNameLongname()
        {
            FlashCardsController testOBJ = new FlashCardsController("a");

            testOBJ.User = "kalle anka från Göteborg i Sverige, Europa, Jorden";

            Assert.AreEqual(testOBJ.User, "kalle anka från Göteborg i Sverige, Europa, Jorden");
        }

        [TestMethod]
        public void SetPlayerNameShortname()
        {
            FlashCardsController testOBJ = new FlashCardsController("a");

            testOBJ.User = "T";

            Assert.AreEqual(testOBJ.User, "T");
        }

        [TestMethod]
        public void SetPlayerNameWithFunnyCharacters()
        {
            FlashCardsController testOBJ = new FlashCardsController("a");

            testOBJ.User = "kalle % # ; =} * á le´ ä ' ~";

            Assert.AreEqual(testOBJ.User, "kalle % # ; =} * á le´ ä ' ~");
        }

        [TestMethod]
        public void SetPlayerNameWithFunnyCharacters2()
        {
            FlashCardsController testOBJ = new FlashCardsController("a");

            testOBJ.User = "john*^`?=)(/&%¤#!½_AppDomain:;*ÄÅÖ";

            Assert.AreEqual(testOBJ.User, "john*^`?=)(/&%¤#!½_AppDomain:;*ÄÅÖ");
        }

        [TestMethod]
        public void SetPlayerNameWithFunnyCharacters3()
        {
            FlashCardsController testOBJ = new FlashCardsController("a");

            testOBJ.User = "'";

            Assert.AreEqual(testOBJ.User, "'");
        }

        [TestMethod]
        public void SetNumber1()
        {
            FlashCardsController testOBJ = new FlashCardsController("a");

            testOBJ.Number1 = 1;

            Assert.AreEqual(testOBJ.Number1, 1);
        }

        [TestMethod]
        public void SetNumber2()
        {
            FlashCardsController testOBJ = new FlashCardsController("a");

            testOBJ.Number2 = 1;

            //Assert.AreNotEqual(testOBJ.Number2, 1);
            Assert.AreEqual(testOBJ.Number2, 1);
        }

        [TestMethod]
        public void WorkOnLetterA()
        {
            FlashCardsController testOBJ = new FlashCardsController("a");

            Assert.AreEqual(testOBJ.WorkOn, "A");

            testOBJ.WorkOn = "A";

            Assert.AreEqual(testOBJ.WorkOn, "A");
        }

        [TestMethod]
        public void WorkOnLetterS()
        {
            FlashCardsController testOBJ = new FlashCardsController("s");

            Assert.AreEqual(testOBJ.WorkOn, "S");

            testOBJ.WorkOn = "S";

            Assert.AreEqual(testOBJ.WorkOn, "S");
        }

        [TestMethod]
        public void WorkOnLetterM()
        {
            FlashCardsController testOBJ = new FlashCardsController("m");

            Assert.AreEqual(testOBJ.WorkOn, "M");
            
            testOBJ.WorkOn = "M";

            Assert.AreEqual(testOBJ.WorkOn, "M");
        }

        [TestMethod]
        public void WorkOnLetterD()
        {
            FlashCardsController testOBJ = new FlashCardsController("d");

            Assert.AreEqual(testOBJ.WorkOn, "D");

            testOBJ.WorkOn = "D";

            ///HACK Error
            Assert.AreEqual(testOBJ.WorkOn, "D");
        }

        //TODO Fix UT for the exception. This still does not work because I (Erik) really do not understand it
        /*[TestMethod]
        public void WorkOnLetter_other()
        {
            FlashCardsController testOBJ = new FlashCardsController("x");

            UnittestOBJAssertException.Equals(System.ArgumentException("Must enter Add, Subtract, Multiply or Divide")); 
            
            testOBJ.WorkOn = "X";

            UnittestOBJAssertException.Equals(System.ArgumentException("Must enter Add, Subtract, Multiply or Divide"));
        }
         */

        //REFACTOR Understand how to do this!
        [TestMethod]
        public void SetNumber1Multiplication()
        {
            FlashCardsController testOBJ = new FlashCardsController("m");

            Assert.AreEqual(testOBJ.WorkOn, "M");

            testOBJ.GenerateNumbers();

            Assert.IsTrue(testOBJ.Number1 < 13);
            Assert.IsTrue(testOBJ.Number1 > 0);

        }

        [TestMethod]
        public void SetNumber2Multiplication()
        {
            FlashCardsController testOBJ = new FlashCardsController("m");

            Assert.AreEqual(testOBJ.WorkOn, "M");

            testOBJ.GenerateNumbers();

            Assert.IsTrue(testOBJ.Number2 < 13);
            Assert.IsTrue(testOBJ.Number2 > 0);

        }

        [TestMethod]
        public void SetNumber1Division()
        {
            FlashCardsController testOBJ = new FlashCardsController("d");

            Assert.AreEqual(testOBJ.WorkOn, "D");

            testOBJ.GenerateNumbers();

            Assert.IsTrue(testOBJ.Number1 < 82);
            Assert.IsTrue(testOBJ.Number1 > 0);
        }

        [TestMethod]
        public void SetNumber2Division()
        {
            FlashCardsController testOBJ = new FlashCardsController("d");

            Assert.AreEqual(testOBJ.WorkOn, "D");

            testOBJ.GenerateNumbers();

            Assert.IsTrue(testOBJ.Number2 < 10);
            Assert.IsTrue(testOBJ.Number2 > 0);
        }

        [TestMethod]
        public void GetAndSetTries()
        {
            FlashCardsController testOBJ = new FlashCardsController("a");

            Assert.AreEqual(testOBJ.Tries, 0);

            testOBJ.Number1 = 50;
            testOBJ.Number2 = 5;

            testOBJ.CheckAnswer(55);

            Assert.AreEqual(testOBJ.Tries, 1);
        }

        //REFACTOR Fix this method so that it loops for all 4
        [TestMethod]
        public void GetAndSetCorrectAddition()
        {
            FlashCardsController testOBJ = new FlashCardsController("a");

            Assert.AreEqual(testOBJ.Correct, 0);

            testOBJ.Number1 = 50;
            testOBJ.Number2 = 5;

            testOBJ.CheckAnswer(55);

            Assert.AreEqual(testOBJ.Correct, 1);
        }

        [TestMethod]
        public void GetAndSetCorrectSubtraction()
        {
            FlashCardsController testOBJ = new FlashCardsController("s");

            Assert.AreEqual(testOBJ.Correct, 0);

            testOBJ.Number1 = 50;
            testOBJ.Number2 = 5;

            testOBJ.CheckAnswer(45);

            Assert.AreEqual(testOBJ.Correct, 1);
        }

        [TestMethod]
        public void GetAndSetCorrectMultiplication()
        {
            FlashCardsController testOBJ = new FlashCardsController("m");

            Assert.AreEqual(testOBJ.Correct, 0);

            testOBJ.Number1 = 50;
            testOBJ.Number2 = 5;

            testOBJ.CheckAnswer(250);

            Assert.AreEqual(testOBJ.Correct, 1);
        }

        [TestMethod]
        public void GetAndSetCorrectDivision()
        {
            FlashCardsController testOBJ = new FlashCardsController("d");

            Assert.AreEqual(testOBJ.Correct, 0);

            testOBJ.Number1 = 50;
            testOBJ.Number2 = 5;

            testOBJ.CheckAnswer(10);

            Assert.AreEqual(testOBJ.Correct, 1);
        }

        [TestMethod]
        public void GetAndSetScoreAddition()
        {
            FlashCardsController testOBJ = new FlashCardsController("a");

            Assert.AreEqual(testOBJ.Score, 0);

            testOBJ.Number1 = 50;
            testOBJ.Number2 = 5;

            testOBJ.CheckAnswer(55);

            Assert.AreEqual(testOBJ.Score, 10);
        }

        [TestMethod]
        public void GetAndSetScoreSubtraction()
        {
            FlashCardsController testOBJ = new FlashCardsController("s");

            Assert.AreEqual(testOBJ.Score, 0);

            testOBJ.Number1 = 50;
            testOBJ.Number2 = 5;

            testOBJ.CheckAnswer(45);

            Assert.AreEqual(testOBJ.Score, 10);
        }

        [TestMethod]
        public void GetAndSetScoreMultiplication()
        {
            FlashCardsController testOBJ = new FlashCardsController("m");

            Assert.AreEqual(testOBJ.Score, 0);

            testOBJ.Number1 = 50;
            testOBJ.Number2 = 5;

            testOBJ.CheckAnswer(250);

            Assert.AreEqual(testOBJ.Score, 10);
        }

        [TestMethod]
        public void GetAndSetScoreDivision()
        {
            FlashCardsController testOBJ = new FlashCardsController("d");

            Assert.AreEqual(testOBJ.Score, 0);

            testOBJ.Number1 = 50;
            testOBJ.Number2 = 5;

            testOBJ.CheckAnswer(10);

            Assert.AreEqual(testOBJ.Score, 10);
        }

        [TestMethod]
        public void GetAndSetCorrectFail()
        {
            FlashCardsController testOBJ = new FlashCardsController("a");

            Assert.AreEqual(testOBJ.Correct, 0);

            testOBJ.Number1 = 50;
            testOBJ.Number2 = 0;

            testOBJ.CheckAnswer(55);

            Assert.AreEqual(testOBJ.Correct, 0);
        }

        [TestMethod]
        public void GetAndSetScoreFail()
        {
            FlashCardsController testOBJ = new FlashCardsController("a");

            Assert.AreEqual(testOBJ.Score, 0);

            testOBJ.Number1 = 50;
            testOBJ.Number2 = 0;

            testOBJ.CheckAnswer(55);
            
            Assert.AreEqual(testOBJ.Score, 0);
        }

        [TestMethod]
        public void CheckAnswerTrueDivision()
        {
            FlashCardsController testOBJ = new FlashCardsController("d");

            testOBJ.Number1 = 50;
            testOBJ.Number2 = 5;

            Assert.IsTrue(testOBJ.CheckAnswer(10));
        }

        [TestMethod]
        public void CheckAnswerTrueAddition()
        {
            FlashCardsController testOBJ = new FlashCardsController("a");

            testOBJ.Number1 = 50;
            testOBJ.Number2 = 5;

            Assert.IsTrue(testOBJ.CheckAnswer(55));
        }

        [TestMethod]
        public void CheckAnswerTrueSubtraction()
        {
            FlashCardsController testOBJ = new FlashCardsController("s");

            testOBJ.Number1 = 50;
            testOBJ.Number2 = 5;

            Assert.IsTrue(testOBJ.CheckAnswer(45));
        }

        [TestMethod]
        public void CheckAnswerTrueMultiplication()
        {
            FlashCardsController testOBJ = new FlashCardsController("m");

            testOBJ.Number1 = 50;
            testOBJ.Number2 = 5;

            Assert.IsTrue(testOBJ.CheckAnswer(250));
        }

        [TestMethod]
        public void CheckAnswerFalseAddition()
        {
            FlashCardsController testOBJ = new FlashCardsController("a");

            testOBJ.Number1 = 50;
            testOBJ.Number2 = 0;

            Assert.IsFalse(testOBJ.CheckAnswer(55));
        }

        [TestMethod]
        public void CheckAnswerFalseSubtraction()
        {
            FlashCardsController testOBJ = new FlashCardsController("s");

            testOBJ.Number1 = 50;
            testOBJ.Number2 = 0;

            Assert.IsFalse(testOBJ.CheckAnswer(45));
        }

        [TestMethod]
        public void CheckAnswerFalseMultiplication()
        {
            FlashCardsController testOBJ = new FlashCardsController("m");

            testOBJ.Number1 = 50;
            testOBJ.Number2 = 4;

            Assert.IsFalse(testOBJ.CheckAnswer(250));
        }

        [TestMethod]
        public void CheckAnswerFalseDivision()
        {
            FlashCardsController testOBJ = new FlashCardsController("d");

            testOBJ.Number1 = 50;
            testOBJ.Number2 = 5;

            Assert.IsFalse(testOBJ.CheckAnswer(11));
        }

        [TestMethod]
        public void BuildEquationAddition()
        {
            FlashCardsController testOBJ = new FlashCardsController("a");

            testOBJ.Number1 = 50;
            testOBJ.Number2 = 5;

            Assert.AreEqual(testOBJ.BuildEquation(), "50+5");      
        }
        [TestMethod]
        public void BuildEquationSubtraction()
        {
            FlashCardsController testOBJ = new FlashCardsController("s");

            testOBJ.Number1 = 50;
            testOBJ.Number2 = 5;

            Assert.AreEqual(testOBJ.BuildEquation(), "50-5");
        }

        [TestMethod]
        public void BuildEquationMultiplication()
        {
            FlashCardsController testOBJ = new FlashCardsController("m");

            testOBJ.Number1 = 50;
            testOBJ.Number2 = 5;

            Assert.AreEqual(testOBJ.BuildEquation(), "50*5");
        }
        [TestMethod]

        public void BuildEquationDivision()
        {
            FlashCardsController testOBJ = new FlashCardsController("d");

            testOBJ.Number1 = 50;
            testOBJ.Number2 = 5;

            Assert.AreEqual(testOBJ.BuildEquation(), "50/5");
        }
    }
}
