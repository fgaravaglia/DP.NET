using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BehavioralPatterns.Iterator
{
    // T is the data type. The Node type is built-in.
    public class Tree<T>
    {
        public Node<T> Root { get; set; }

        public Tree() { }

        public Tree(Node<T> head)
        {
            Root = head;
        }
    }
}
