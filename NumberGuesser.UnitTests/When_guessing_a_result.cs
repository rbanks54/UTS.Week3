using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace NumberGuesser.UnitTests
{
    [TestClass]
    public class When_guessing_a_result
    {
        [TestMethod]
        public void A_correct_guess_should_be_successful()
        {
            var random = new Mock<INumberGenerator>();
            random.Setup(x => x.Next()).Returns(2);
            Game game = new Game(random.Object);
            game.Start();
            Assert.AreEqual(Result.Correct, game.Guess(1));
        }
    }
}
