using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StructuralPatterns.Decorator
{
    public class Component : IComponent
    {
        public string Operation()
        {
            return "I am walking ";
        }
    }
}
