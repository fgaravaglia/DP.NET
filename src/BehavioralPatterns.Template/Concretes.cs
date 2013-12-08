using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BehavioralPatterns.Template
{
    public class ClassA : IPrimitives
    {
        public string Operation1()
        {
            return "ClassA:Op1 ";
        }
        public string Operation2()
        {
            return "ClassA:Op2 ";
        }
    }

    public class ClassB : IPrimitives
    {
        public string Operation1()
        {
            return "ClassB:Op1 ";
        }
        public string Operation2()
        {
            return "ClassB.Op2 ";
        }
    }
}
