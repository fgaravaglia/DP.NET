using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StructuralPatterns.Flyweight
{
    public class FlyweightFactory
    { 
        // Keeps an indexed list of IFlyweight objects in existence
        Dictionary<string, IFlyweight> flyweights = new Dictionary<string, IFlyweight>();
        
        public IFlyweight this[string index]
        {
            get
            {
                if (!flyweights.ContainsKey(index))
                    flyweights[index] = new Flyweight();
                return flyweights[index];
            }
        }

        public FlyweightFactory()
        {
            flyweights.Clear();
        }

    }
}
