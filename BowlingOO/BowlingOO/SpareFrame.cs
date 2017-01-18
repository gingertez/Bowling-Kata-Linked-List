using System.Collections.Generic;

namespace BowlingLinkedList
{
    public class SpareFrame : IFrame
    {
        private int? _nextRoll = 0;
        public SpareFrame(string frameScore)
        {
            FirstRoll = frameScore[0].GetRollValue();
        }

        public int FirstRoll { get; private set; }
        
        public int Score(LinkedListNode<IFrame> node = null)
        {
            int score = node.IsBonusBallsFrame() ? 0 : 10;

            if (node != null && node.Next != null)
            {
                score += node.Next.Value.FirstRoll;
            }
            return score;
        }
    }
}
