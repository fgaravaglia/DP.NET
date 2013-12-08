using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BehavioralPatterns.Strategy
{
    interface IStrategy
    {
        int Move(Context c);
    }
}
