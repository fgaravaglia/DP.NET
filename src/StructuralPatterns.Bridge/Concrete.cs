using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StructuralPatterns.Bridge
{
    public class ConcreteA : IBridge
    {
        public string Operation()
        {
            return "Concrete implementation A";
        }
    }

    public class ConcreteB : IBridge
    {
        public string Operation()
        {
            return "Concrete implementation B";
        }
    }
}
