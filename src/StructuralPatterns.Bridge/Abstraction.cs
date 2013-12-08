using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StructuralPatterns.Bridge
{
    public class Abstraction
    {
        IBridge bridge;

        public Abstraction(IBridge b)
        {
            bridge = b;
        }

        public string PerformOperation()
        {
            return "Abstraction <<< BRIDGE >>> " + bridge.Operation();
        }
    }
}
