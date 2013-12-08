using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CreationalPatterns.AbstractFactory
{
    // Interface IProductA
    interface IBag
    {
        string Material { get; }
    }

    // Interface IProductB
    interface IShoes
    {
        int Price { get; }
    }

    // All concrete ProductA's
    class Bag<Brand> : IBag  where Brand : IBrand, new()
    {
        private Brand myBrand;
        public Bag()
        {
            myBrand = new Brand();
        }

        public string Material { get { return myBrand.Material; } }
    }

    // All concrete ProductB's
    class Shoes<Brand> : IShoes where Brand : IBrand, new()
    {
        private Brand myBrand;
        public Shoes()
        {
            myBrand = new Brand();
        }

        public int Price { get { return myBrand.Price; } }
    }
}
