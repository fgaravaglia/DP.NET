using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CreationalPatterns.Builder
{
    public class Director
    {
        // Build a Product from several parts
        public void Construct(IBuilder builder)
        {
            builder.BuildPartA();
            builder.BuildPartB();
            builder.BuildPartB();
        }
    }
}
