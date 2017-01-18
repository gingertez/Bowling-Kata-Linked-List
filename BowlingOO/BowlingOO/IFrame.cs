using System.Collections.Generic;

namespace BowlingLinkedList
{
    public interface IFrame
    {
        int FirstRoll { get; }
        int Score(LinkedListNode<IFrame> node);
    }
}
