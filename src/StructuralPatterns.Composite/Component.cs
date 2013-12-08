using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StructuralPatterns.Composite
{
    /// <summary>
    /// Real Component
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Component<T> : IComponent<T>
    {
        public T Name { get; set; }

        public Component(T name)
        {
            this.Name = name;
        }

        public void Add(IComponent<T> c)
        {
            Console.WriteLine(" > Component: cannot Add the item");
        }

        public IComponent<T> Remove(T s)
        {
            Console.WriteLine(" > Component: cannot remove directly");
            return this;
        }

        public string Display(int depth)
        {
            return new String('-', depth) + this.Name + "\n";
        }

        public IComponent<T> Find(T s)
        {
            if (s.Equals(Name))
                return this;
            else
                return null;
        }
    }
}
