using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingLinkedList
{
    public class StrikeFrame : IFrame
    {
        public int FirstRoll => 10;

        public int Score(LinkedListNode<IFrame> node = null)
        {
            var score = 10;

            if (node != null && node.Next != null)
            {
                score += node.Next.Value.Score(null);

                if (node.Next.Value is StrikeFrame && node.Next.Next != null)
                {
                    score += node.Next.Next.Value.FirstRoll;
                }
            }
            return score;
        }
    }
}
