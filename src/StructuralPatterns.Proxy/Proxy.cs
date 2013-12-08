using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StructuralPatterns.Proxy
{
    public class Proxy : ISubject
    {
        private Subject mySubject = null;

        public string Request()
        { 
            // crea oggetto solo se é la prima volta che viene chiamato
            if (mySubject == null)
            {
                Console.WriteLine("\t> Subject inactive: creating now...");
                mySubject = new Subject();
            }
            else 
                Console.WriteLine("\t> Subject already active");
            return "Proxy: Call to " + mySubject.Request();
        }
    }
}
