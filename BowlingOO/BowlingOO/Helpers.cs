﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace BowlingLinkedList
{
    public static class Helpers
    {
        public const int ASCII_OFFSET = 48;
        public static char[] VALID_CHARS = { 'X', '-', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
        public static int GetRollValue(this char roll)
        {
            if (!VALID_CHARS.Contains(roll))
            {
                throw new InvalidOperationException("Invalid character found in game score");
            }

            if (roll == '-')
            {
                return 0;
            }

            if (roll == 'X')
            {
                return 10;
            }

            return roll - ASCII_OFFSET;
        }

        public static bool IsBonusBallsFrame<T>(this LinkedListNode<T> node)
        {
            return (node != null && node.Next == null);
        }
    }
}
