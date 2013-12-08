using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CreationalPatterns.Factory
{
    public interface IProduct
    {
        string ShipFrom();
    }

    class ProductA : IProduct
    {
        public String ShipFrom()
        {
            return " from South Africa";
        }
    }

    class ProductB : IProduct
    {
        public String ShipFrom()
        {
            return "from Spain";
        }
    }

    class DefaultProduct : IProduct
    {
        public String ShipFrom()
        {
            return "not available";
        }
    }
}
