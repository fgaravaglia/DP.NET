using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StructuralPatterns.Adapter
{
    // Existing way requests are implemented
    public class Adaptee 
    {
         // Provide full precision
        public double SpecificRequest(double a, double b)
        {
            return a / b;
        }
     }

    public interface ITarget
    {
        string Request(int i);
    }

    // Implementing the required standard via Adaptee: Single Adapter
    public class Adapter : Adaptee, ITarget
    {
        public string Request(int i)
        {
            return "Rough estimate is " + (int)Math.Round(SpecificRequest(i, 3));
        }
    }

    // New standard for requests: Pluggable adapter
    public class Target
    {
        public string Estimate(int i)
        {
            return "Estimate is " + (int)Math.Round(i / 3.0);
        }
    }

    // Implementing new requests via old
    public class PluggableAdapter : Adaptee 
    {
        public Func <int,string> Request;

        // Different constructors for the expected targets/adaptees

        // Adapter-Adaptee
        public PluggableAdapter (Adaptee adaptee) 
        {   
            // Set the delegate to the new standard
            Request = delegate(int i) 
            {
                string returnSTr = " > Starting precision is " + SpecificRequest(i, 3);
                returnSTr += ("\n > Estimate based on precision is " + (int)Math.Round(SpecificRequest(i, 3)));
                return returnSTr;
            };
        }

        // Adapter-Target
        public PluggableAdapter(Target target)
        {
            // Set the delegate to the existing standard
            Request = target.Estimate;
        }
 }



}
