using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BehavioralPatterns.Iterator
{
    public class Person
    {
        public string Name { get; set; }
        public int BirthYear { get; set; }

        public Person(string name, int birth)
        {
            Name = name;
            BirthYear = birth;
        }
    }

    public class FamilyTree<T>
    {
        private Tree<T> family = null;

        public FamilyTree(Tree<T> tree)
        {  
            family = tree;
        }

        public IEnumerable<T> Preorder
        {
            get { return ScanPreorder(family.Root); }
        }

        // Enumerator with Filter
        public IEnumerable<T> Where(Func<T, bool> filter)
        {
            foreach (T p in ScanPreorder(family.Root))
                if (filter(p) == true)
                    yield return p;
        }

        // Enumerator with T as Person
        private IEnumerable<T> ScanPreorder(Node<T> root)
        {
            yield return root.Data;
            if (root.Left != null)
                foreach (T p in ScanPreorder(root.Left))
                    yield return p;
            if (root.Right != null)
                foreach (T p in ScanPreorder(root.Right))
                    yield return p;
        }
    }

}
