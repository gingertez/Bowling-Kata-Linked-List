using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BowlingLinkedList;
using NUnit.Framework;

namespace BowlingLinkedListTests
{
    [TestFixture]
    public class FrameTests
    {
        [TestCase("12", 3)]
        [TestCase("81", 9)]
        public void TestFrameScoreWhenFrameIsOnlyNumbers(string frameScore, int expectedScore)
        {
            var frame = new NumericFrame(frameScore);
            Assert.That(frame.Score(), Is.EqualTo(expectedScore));
        }

        [TestCase("--", 0)]
        [TestCase("-2", 2)]
        [TestCase("3-", 3)]
        public void TestFrameScoreWhenThereAreGutterBalls(string frameScore, int expectedScore)
        {
            var frame = new NumericFrame(frameScore);
            Assert.That(frame.Score(), Is.EqualTo(expectedScore));
        }

        [Test]
        public void TestSpareFrameScore()
        {
            var frame = new SpareFrame("1/");
            Assert.That(frame.Score(), Is.EqualTo(10));
        }

        [Test]
        public void TestSpareFrameScoreWithNextRoll()
        {
            var frame = new SpareFrame("1/");
            var node = new LinkedListNode<IFrame>(frame);

            var nextFrame = new NumericFrame("45");

            var ll = new LinkedList<IFrame>();
            ll.AddFirst(node);
            ll.AddLast(nextFrame);

            Assert.That(frame.Score(node), Is.EqualTo(14));
        }

        [Test]
        public void TestSpareFrameFirstRoll()
        {
            var frame = new SpareFrame("1/");
            Assert.That(frame.FirstRoll, Is.EqualTo(1));
        }

        [Test]
        public void TestStrikeFrameScore()
        {
            var frame = new StrikeFrame();
            Assert.That(frame.Score(), Is.EqualTo(10));
        }

        [Test]
        public void TestStrikeFrameScoreWithOneAdditionalRoll()
        {
            var frame = new StrikeFrame();
            var node = new LinkedListNode<IFrame>(frame);

            var nextFrame = new NumericFrame("4");

            var ll = new LinkedList<IFrame>();
            ll.AddFirst(node);
            ll.AddLast(nextFrame);

            Assert.That(frame.Score(node), Is.EqualTo(14));
        }

        [Test]
        public void TestStrikeFrameScoreWithTwoAdditionalRoll()
        {
            var frame = new StrikeFrame();
            var node = new LinkedListNode<IFrame>(frame);

            var nextFrame = new NumericFrame("45");

            var ll = new LinkedList<IFrame>();
            ll.AddFirst(node);
            ll.AddLast(nextFrame);

            Assert.That(frame.Score(node), Is.EqualTo(19));
        }

        [Test]
        public void TestStrikeFrameScoreWithTwoAdditionalFrames()
        {
            var frame = new StrikeFrame();
            var node = new LinkedListNode<IFrame>(frame);

            var nextFrames = new List<IFrame> {
                new StrikeFrame(),
                new NumericFrame("45")
            };

            var ll = new LinkedList<IFrame>(nextFrames);
            ll.AddFirst(node);

            Assert.That(frame.Score(node), Is.EqualTo(24));
        }
    }
}
