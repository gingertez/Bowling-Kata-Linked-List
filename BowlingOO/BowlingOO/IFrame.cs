using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingLinkedList
{
    public interface IFrame
    {
        int FirstRoll { get; }
        int Score();
    }
}
