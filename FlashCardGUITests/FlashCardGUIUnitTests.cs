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

            //REFACTOR this TC
            Assert.AreNotEqual(test.User, "kallde");
        }
    }
}
