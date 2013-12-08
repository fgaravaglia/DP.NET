using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StructuralPatterns.Decorator
{
    public class DecoratorA : IComponent
    {
        private IComponent myComponent = null;

        public DecoratorA(IComponent component)
        {
            myComponent = component;
        }

        public string Operation()
        {
            return myComponent.Operation() + "and listening to Radio ";
        }
    }

    public class DecoratorB : IComponent
    {
        private IComponent myComponent = null;

        public DecoratorB(IComponent component)
        {
            myComponent = component;
        }

        public string Operation()
        {
            return myComponent.Operation() + "to school ";
        }

        public string AddedBehaviour()
        {
            return "and I bought a cappuccino ";
        }
    }
}
