using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CreationalPatterns.Builder
{
    public interface IBuilder
    {
        void BuildPartA();
        void BuildPartB();
        Product GetResult();
    }


}
