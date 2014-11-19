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

            //REFACTOR this TC so that it works better
            //Assert.AreEqual(test.User, "kallde");
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
        public void SetPlayerNameWithFunnyCharacters()
        {
            FlashCardsController test = new FlashCardsController("a");

            test.User = "kalle % # ; =} * á le´ ä ' ~";

            Assert.AreEqual(test.User, "kalle % # ; =} * á le´ ä ' ~");
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
    }
}
