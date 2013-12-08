using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CreationalPatterns.AbstractFactory
{
    public class Gucci : IBrand
    {
        public int Price { get { return 1000; } }
        public string Material { get { return "Crocodile skin"; } }
    }

    public class Poochy : IBrand
    {
        public int Price { get { return new Gucci().Price / 3; } }
        public string Material { get { return "Plastic"; } }
    }

    public class Groundcover : IBrand
    {
        public int Price { get { return 2000; } }
        public string Material { get { return "South african leather"; } }
    }
}
