using System;
using System.Collections.Generic;
using BowlingLinkedList;
using NUnit.Framework;

namespace BowlingLinkedListTests
{
    [TestFixture]
    public class FrameFactoryTests
    {
        [TestCase("X", typeof(StrikeFrame))]
        [TestCase("1/", typeof(SpareFrame))]
        [TestCase("12", typeof(NumericFrame))]
        public void TestCorrectFrameTypeCreated(string frameScore, Type expectedType)
        {
            var createdFrame = FrameFactory.GetFrame(frameScore);

            Assert.That(createdFrame, Is.TypeOf(expectedType));
        }
    }
}
