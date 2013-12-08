using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace BehavioralPatterns.Visitor
{
    public abstract class IVisitor
    {
        public void ReflectiveVisit(Element element)
        {
            Type[] types = new Type[] { element.GetType() };
            MethodInfo methodInfo = this.GetType().GetMethod("Visit", types);
            if (methodInfo != null)
            {
                methodInfo.Invoke(this, new object[] { element });
            }
        }
    }

    public class PrintVisitor : IVisitor
    {
        public void Print(Element element)
        {
            ReflectiveVisit(element);
            if (element.Part != null)
            {
                Console.Write(" [");
                Print(element.Part);
            }
            if (element.Next != null) Print(element.Next);
            Console.Write("] ");
        }
        public void Visit(Element element)
        {
            Console.Write(" " + element.Weight);
        }
    }

    public class StructureVisitor : IVisitor
    {
        public int Lab { get; set; }
        public int Test { get; set; }
        public void Summarize(Element element)
        {
            ReflectiveVisit(element);
            //if (element.Part != null) VisitAllLabTest(element.Part.Next);
            //if (element.Next != null) VisitAllLabTest(element.Next);
        }
        public void Visit(Lab element)
        {
            Lab += element.Weight;
        }
        public void Visit(Test element)
        {
            Test += element.Weight;
        }
        public void Visit(Element element)
        {
            if ((element is Midterm || element is Exam)
            && element.Part == null) Test += element.Weight;
        }
    }
}
