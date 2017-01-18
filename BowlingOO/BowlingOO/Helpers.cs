using System.Collections.Generic;

namespace BowlingLinkedList
{
    public static class Helpers
    {
        public const int ASCII_OFFSET = 48;
        public static int GetRollValue(this char roll)
        {
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
