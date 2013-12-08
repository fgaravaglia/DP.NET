using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StructuralPatterns.Composite
{
    public interface IComponent<T>
    {
        T Name { get; set; }

        void Add(IComponent<T> c);
        IComponent<T> Remove(T s);
        string Display(int depth);
        IComponent<T> Find(T s);
    }
}
