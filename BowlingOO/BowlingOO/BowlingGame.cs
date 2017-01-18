using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BowlingLinkedList
{
    public class BowlingGame
    {
        LinkedList<IFrame> _frames = new LinkedList<IFrame>();
        public BowlingGame(string gameScore)
        {
            var frameScores = gameScore.Replace("||", "|").Split('|');
            var idx = 0;
            foreach (var frameScore in frameScores)
            {
                idx++;
                _frames.AddLast(FrameFactory.GetFrame(frameScore, frameScores.Skip(idx).ToList()));
            }
        }

        public int Score()
        {
            var score = 0;
            var enumerator = _frames.GetEnumerator();
            IFrame current;
            while (enumerator.MoveNext())
            {
                current = enumerator.Current;
                score += current.Score(_frames.Find(current));
            }
            return score;
        }
    }
}
