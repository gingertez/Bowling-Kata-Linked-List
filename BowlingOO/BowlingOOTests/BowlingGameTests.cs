using BowlingLinkedList;
using NUnit.Framework;

namespace BowlingLinkedListTests
{
    [TestFixture]
    public class BowlingGameTests
    {
        [TestCase("1-|1-|1-|1-|1-|1-|1-|1-|1-|1-||", 10)]
        [TestCase("5/|5/|5/|5/|5/|5/|5/|5/|5/|5/||5", 150)]
        [TestCase("X|7/|9-|X|-8|8/|-6|X|X|X||81", 167)]
        [TestCase("X|X|X|X|X|X|X|X|X|X||XX", 300)]
        [TestCase("X|7/|9-|X|-8|8/|-6|X|X|X||8/", 168)]
        public void TestGameScore(string gameScore, int expectedScore)
        {
            var game = new BowlingGame(gameScore);
            var score = game.Score();
            Assert.That(score, Is.EqualTo(expectedScore));
        }
    }
}
