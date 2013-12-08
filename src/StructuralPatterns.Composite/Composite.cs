using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StructuralPatterns.Composite
{
    public class Composite<T> : IComponent<T>
    {
        private List<IComponent<T>> list = new List<IComponent<T>>();
        private IComponent<T> holder = null;
        public T Name { get; set; }

        public Composite(T name)
        {
            this.Name = name;
            this.list = new List<IComponent<T>>();
        }

        public void Add(IComponent<T> c)
        {
            list.Add(c);
        }

        public IComponent<T> Remove(T s)
        {
            holder = this;
            var p = holder.Find(s);
            if (holder != null)
            {
                (holder as Composite<T>).list.Remove(p);
                return holder;
            }
            else
                return this;
        }

        public string Display(int depth)
        {
            StringBuilder s = new StringBuilder(new String('-', depth));
            s.Append(" Set " + Name + " lenght: " + list.Count + "\n");
            foreach(var item in list)
                s.Append(item.Display(depth + 2));
            return s.ToString();
        }

        public IComponent<T> Find(T s)
        {
            holder = this;
            if (Name.Equals(s))
                return this;
            IComponent<T> found = null;
            foreach (var c in list)
            {
                found = c.Find(s);
                if (found != null) break;
            }
            return found;
        }
    }
}
