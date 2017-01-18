using BowlingLinkedList;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingLinkedListTests
{
    [TestFixture]
    public class HelperTests
    {
        [TestCase('1', 1)]
        [TestCase('-', 0)]
        [TestCase('X', 10)]
        public void TestRollValue(char roll, int expectedValue)
        {
            Assert.That(roll.GetRollValue(), Is.EqualTo(expectedValue));
        }

        [TestCase(null, null, false)]
        [TestCase("value", null, true)]
        [TestCase("value", "value", false)]
        public void TestIsBonusBallsFrame(string nodeValue, string nextNodeValue, bool expected)
        {
            LinkedListNode<string> node;
            LinkedList<string> ll = new LinkedList<string>();

            if (nodeValue == null)
            {
                node = null;
            }
            else
            {
                node = new LinkedListNode<string>(nodeValue);
            }

            if (nextNodeValue != null)
            {
                ll.AddFirst(node);
                ll.AddLast(nextNodeValue);
            }

            Assert.That(node.IsBonusBallsFrame(), Is.EqualTo(expected));
        }
    }
}
