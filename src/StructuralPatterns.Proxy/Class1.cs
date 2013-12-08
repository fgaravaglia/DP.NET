using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StructuralPatterns.Proxy
{
    public interface ISubject
    {
        string Request();
    }

    public class Subject
    {
        public string Request()
        {
            return "Subject Request Choose ledt door \n";
        }
    }
}
