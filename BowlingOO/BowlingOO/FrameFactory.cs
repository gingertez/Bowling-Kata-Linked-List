﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                return new SpareFrame(
                    frameScore, 
                    nextFrames?.Count > 0 ? nextFrames[0] : null);
            }

            return new NumericFrame(frameScore);
        }
    }
}
