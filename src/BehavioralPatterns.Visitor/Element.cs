using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BehavioralPatterns.Visitor
{
    public class Element
    {
        public int Weight { get; set; }
        public Element Next { get; set; }
        public Element Part { get; set; }
        public void Parse(Context context)
        {
            string starters = "LTME";
            if (context.Input.Length > 0 && starters.IndexOf(context.Input[0]) >= 0)
            {
                switch (context.Input[0])
                {
                    case 'L':
                        Next = new Lab();
                        break;
                    case 'T':
                        Next = new Test();
                        break;
                    case 'M':
                        Next = new Midterm();
                        break;
                    case 'E':
                        Next = new Exam();
                        break;
                }
                Next.Weight = Context.GetNumber(context);
                if (context.Input.Length > 0 && context.Input[0] == '(')
                {
                    context.Input = context.Input.Substring(1);
                    Next.Part = new Element();
                    Next.Part.Parse(context);
                    Element e = Next.Part;
                    while (e != null)
                    {
                        e.Weight = e.Weight * Next.Weight / 100;
                        e = e.Next;
                    }
                    context.Input = context.Input.Substring(2);
                }
                Next.Parse(context);
            }
        }
    }
    
    public class Course : Element
    {
        public string Name { get; set; }
        public Course(Context context)
        {
            Name = context.Input.Substring(0, 6);
            context.Input = context.Input.Substring(7);
        }
    }
    
    public class Lab : Element
    {
    }
    public class Test : Element
    {
    }
    
    public class Midterm : Element
    {
    }
    
    public class Exam : Element
    {
    }
}
