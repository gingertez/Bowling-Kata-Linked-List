using System.Collections.Generic;

namespace BowlingLinkedList
{
    public static class FrameFactory
    {
        public static IFrame GetFrame(string frameScore, List<string> nextFrames = null)
        {
            if (string.IsNullOrEmpty(frameScore))
            {
                return new NumericFrame("--");
            }

            if (frameScore == "X")
            {
                return new StrikeFrame();
            }

            if (frameScore.Length > 1 && frameScore[1] == '/')
            {
                return new SpareFrame(frameScore);
            }

            return new NumericFrame(frameScore);
        }
    }
}
