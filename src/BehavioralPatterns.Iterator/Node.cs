using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BehavioralPatterns.Iterator
{
    public class Node<T>
    {
        public Node() { }
        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }
        public T Data { get; set; }
        public Node(T d, Node<T> left, Node<T> right)
        {
            Data = d;
            Left = left;
            Right = right;
        }
    }
}
