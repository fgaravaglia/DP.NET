using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StructuralPatterns.Proxy
{
    public class SecurityProxy : ISubject
    {
        // ask the password
        Subject mySubject = null;
        string pwd = "abracadabra";

        public string Authenticate(string supplied)
        {
            if (supplied.ToLower() != pwd.ToLower())
            {
                return "\t> SecurityProxy: Wrong Password";
            }
            else 
            {
                mySubject = new Subject();
                return "\t> SecurityProxy: Authenticated";
            }
        }

        public string Request()
        {
            if (mySubject == null)
                return "\t> SecurityProxy: Authenticate first";
            else
                return "SecurityProxy: Call to " + mySubject.Request();
        }
    }
}
