using System.Collections.Generic;

namespace BowlingLinkedList
{
    public class StrikeFrame : IFrame
    {
        public int FirstRoll => 10;

        public int Score(LinkedListNode<IFrame> node = null)
        {
            int score = node.IsBonusBallsFrame() ? 0 : 10;

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
