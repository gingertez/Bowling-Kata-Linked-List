using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            var score = 10;

            if (node != null && node.Next != null)
            {
                score += node.Next.Value.FirstRoll;
            }
            return score;
        }
    }
}
