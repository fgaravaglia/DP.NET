using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CreationalPatterns.AbstractFactory
{
    // An interface for all Brands
    public interface IBrand
    {
        int Price { get; }
        string Material { get; }
    }
}
