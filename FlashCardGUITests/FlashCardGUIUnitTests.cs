using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FlashCardsLibrary;

namespace FlashCardGUIUnitTests
{
    [TestClass]
    public class FlashCardGUIUnitTests
    {

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

            Assert.AreEqual(test.User, "kallde");

        }
    }

}
