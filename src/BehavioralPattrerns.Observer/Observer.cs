using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BehavioralPattrerns.Observer
{
    public interface IObserver
    {
        void Update(string state);
    }

    public class Observer : IObserver
    {
        string name;
        Subject subject;
        string state;
        string gap;

        public Observer(Subject subject, string name, string gap)
        {
            this.subject = subject;
            this.name = name;
            this.gap = gap;
            subject.Notify += Update;
        }

        public void Update(string subjectState)
        {
            state = subjectState;
            Console.WriteLine(gap + name + ": " + state);
        }
    }
}
