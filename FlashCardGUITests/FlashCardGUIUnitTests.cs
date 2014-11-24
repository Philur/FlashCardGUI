using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FlashCardsLibrary;

namespace FlashCardGUIUnitTests
{
    [TestClass]
    public class FlashCardGUIUnitTests
    {
        //TODO Add more UnitTest!!
        [TestMethod]
        public void SetPlayerName()
        {
            FlashCardsController test = new FlashCardsController("a");

            test.User = "kalle";

            Assert.AreEqual(test.User, "kalle");
        }
        
        [TestMethod]
        public void SetPlayerNameFail()
        {
            FlashCardsController test = new FlashCardsController("a");

            test.User = "kalle";

            //TODO this TC is to break the test chain
            //Assert.AreEqual(test.User, "kallde");
            //REFACTOR this TC so that it works better
            Assert.AreNotEqual(test.User, "kallde");
        }

        [TestMethod]
        public void SetPlayerNameLongname()
        {
            FlashCardsController test = new FlashCardsController("a");

            test.User = "kalle anka från Göteborg i Sverige, Europa, Jorden";

            Assert.AreEqual(test.User, "kalle anka från Göteborg i Sverige, Europa, Jorden");
        }
        
        [TestMethod]
        public void SetPlayerNameShortname()
        {
            FlashCardsController test = new FlashCardsController("a");

            test.User = "T";

            Assert.AreEqual(test.User, "T");
        }

        [TestMethod]
        public void SetPlayerNameWithFunnyCharacters()
        {
            FlashCardsController test = new FlashCardsController("a");

            test.User = "kalle % # ; =} * á le´ ä ' ~";

            Assert.AreEqual(test.User, "kalle % # ; =} * á le´ ä ' ~");
        }

        [TestMethod]
        public void SetPlayerNameWithFunnyCharacters2()
        {
            FlashCardsController test = new FlashCardsController("a");

            test.User = "john*^`?=)(/&%¤#!½_AppDomain:;*ÄÅÖ";

            Assert.AreEqual(test.User, "john*^`?=)(/&%¤#!½_AppDomain:;*ÄÅÖ");
        }
        
        [TestMethod]
        public void SetPlayerNameWithFunnyCharacters3()
        {
            FlashCardsController test = new FlashCardsController("a");

            test.User = "'";

            Assert.AreEqual(test.User, "'");
        }

        [TestMethod]
        public void SetNumber1()
        {
            FlashCardsController test = new FlashCardsController("a");

            test.Number1 = 1;

            Assert.AreEqual(test.Number1, 1);
        }
        
        [TestMethod]
        public void SetNumber2()
        {
            FlashCardsController test = new FlashCardsController("a");

            test.Number2 = 1;

            //Assert.AreNotEqual(test.Number2, 1);
            Assert.AreEqual(test.Number2, 1);
        }

        [TestMethod]
        public void WorkOnLetter_a()
        {
            FlashCardsController test = new FlashCardsController("a");

            Assert.AreEqual(test.WorkOn, "A");

            test.WorkOn = "A";

            Assert.AreEqual(test.WorkOn, "A");
        }

        [TestMethod]
        public void WorkOnLetter_s()
        {
            FlashCardsController test = new FlashCardsController("s");

            Assert.AreEqual(test.WorkOn, "S");

            test.WorkOn = "S";

            Assert.AreEqual(test.WorkOn, "S");
        }

        [TestMethod]
        public void WorkOnLetter_m()
        {
            FlashCardsController test = new FlashCardsController("m");

            Assert.AreEqual(test.WorkOn, "M");
            
            test.WorkOn = "M";

            Assert.AreEqual(test.WorkOn, "M");
        }

        [TestMethod]
        public void WorkOnLetter_d()
        {
            FlashCardsController test = new FlashCardsController("d");

            Assert.AreEqual(test.WorkOn, "D");

            test.WorkOn = "D";

            ///HACK Error
            Assert.AreEqual(test.WorkOn, "D");
        }

        //TODO Fix UT for the exception. This still does not work because I (Erik) really do not understand it
        /*[TestMethod]
        public void WorkOnLetter_other()
        {
            FlashCardsController test = new FlashCardsController("x");

            UnitTestAssertException.Equals(System.ArgumentException("Must enter Add, Subtract, Multiply or Divide")); 
            
            test.WorkOn = "X";

            UnitTestAssertException.Equals(System.ArgumentException("Must enter Add, Subtract, Multiply or Divide"));
        }
         */

        //HACK Understand how to do this!
        [TestMethod]
        public void SetNumber1Multiplication()
        {
            FlashCardsController test = new FlashCardsController("m");

            Assert.AreEqual(test.WorkOn, "M");

            test.GenerateNumbers();

            Assert.IsTrue(test.Number1 < 13);
            Assert.IsTrue(test.Number1 > 0);

        }

        [TestMethod]
        public void SetNumber2Multiplication()
        {
            FlashCardsController test = new FlashCardsController("m");

            Assert.AreEqual(test.WorkOn, "M");

            test.GenerateNumbers();

            Assert.IsTrue(test.Number2 < 13);
            Assert.IsTrue(test.Number2 > 0);

        }

        [TestMethod]
        public void GetAndSetTries()
        {
            FlashCardsController test = new FlashCardsController("a");

            Assert.AreEqual(test.Tries, 0);

            test.Number1 = 50;
            test.Number2 = 5;

            test.CheckAnswer(55);

            Assert.AreEqual(test.Tries, 1);
        }

        [TestMethod]
        public void GetAndSetCorrect()
        {
            FlashCardsController test = new FlashCardsController("a");

            Assert.AreEqual(test.Correct, 0);

            test.Number1 = 50;
            test.Number2 = 5;

            test.CheckAnswer(55);

            Assert.AreEqual(test.Correct, 1);
        }
        
        [TestMethod]
        public void GetAndSetScore()
        {
            FlashCardsController test = new FlashCardsController("a");

            Assert.AreEqual(test.Score, 0);

            test.Number1 = 50;
            test.Number2 = 5;

            test.CheckAnswer(55);

            Assert.AreEqual(test.Score, 10);
        }

        [TestMethod]
        public void BuildEquationAddition()
        {
            FlashCardsController test = new FlashCardsController("a");

            test.Number1 = 50;
            test.Number2 = 5;

            Assert.AreEqual(test.BuildEquation(), "50+5");      
        }
        [TestMethod]
        public void BuildEquationSubtraction()
        {
            FlashCardsController test = new FlashCardsController("s");

            test.Number1 = 50;
            test.Number2 = 5;

            Assert.AreEqual(test.BuildEquation(), "50-5");
        }

        [TestMethod]
        public void BuildEquationMultiplication()
        {
            FlashCardsController test = new FlashCardsController("m");

            test.Number1 = 50;
            test.Number2 = 5;

            Assert.AreEqual(test.BuildEquation(), "50*5");
        }
        [TestMethod]

        public void BuildEquationDivision()
        {
            FlashCardsController test = new FlashCardsController("d");

            test.Number1 = 50;
            test.Number2 = 5;

            Assert.AreEqual(test.BuildEquation(), "50/5");
        }
    }
}
