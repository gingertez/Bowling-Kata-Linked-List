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
        public SpareFrame(string frameScore, string nextFrameScore)
        {
            FirstRoll = frameScore[0].GetRollValue();
            _nextRoll = FrameFactory.GetFrame(nextFrameScore, new List<string>()).FirstRoll;
        }

        public int FirstRoll { get; private set; }
        
        public int Score(LinkedListNode<IFrame> node = null)
        {
            return 10 + (_nextRoll ?? 0);
        }
    }
}
