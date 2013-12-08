using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BehavioralPatterns.Strategy
{
    class Strategy1 : IStrategy
    {
        public int Move(Context c)
        {
            return ++c.Counter;
        }
    }

    // Strategy 2
    class Strategy2 : IStrategy
    {
        public int Move(Context c)
        {
            return --c.Counter;
        }
    }
}
