using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BehavioralPatterns.Visitor
{
    public class Context 
    {
        public string Input {get; set;}
        public double Output {get; set;}
        public Context(string c) 
        {
            Input = c;
            Output = 0;
        }

        public static int GetNumber(Context context)
        {
            int atSpace = context.Input.IndexOf(' ');
            int number = Int32.Parse(context.Input.Substring(1, atSpace));
            context.Input = context.Input.Substring(atSpace + 1);
            return number;
        }
    }

}
