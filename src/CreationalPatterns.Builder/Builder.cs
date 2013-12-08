using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CreationalPatterns.Builder
{
    public class Builder1 : IBuilder
    {
        private Product product = new Product();
        public void BuildPartA()
        {
            product.Add("PartA ");
        }

        public void BuildPartB()
        {
            product.Add("PartB ");
        }

        public Product GetResult()
        {
            return product;
        }
    }

    public class Builder2 : IBuilder
    {
        private Product product = new Product();
        public void BuildPartA()
        {
            product.Add("PartX ");
        }

        public void BuildPartB()
        {

            product.Add("PartY ");
        }

        public Product GetResult()
        {
            return product;
        }
    }
}
