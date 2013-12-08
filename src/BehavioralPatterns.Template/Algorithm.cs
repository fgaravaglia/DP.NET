using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BehavioralPatterns.Template
{
    public class Algorithm
    {
        public void TemplateMethod(IPrimitives a)
        {
            string s =
            a.Operation1() +
            a.Operation2();
            Console.WriteLine(s);
        }
    }
}
