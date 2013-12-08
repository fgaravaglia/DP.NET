using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CreationalPatterns.Builder
{
    public class Product
    {
        List<string> parts = new List<string>();
        public void Add(string part)
        {
            parts.Add(part);
        }

        public void Display()
        {
            Console.WriteLine("\nProduct Parts -------");
            foreach (string part in parts)
                Console.Write(part);
            Console.WriteLine();
        }
    }
}
