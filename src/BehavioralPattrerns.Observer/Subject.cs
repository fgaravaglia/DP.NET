using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace BehavioralPattrerns.Observer
{
    public class Simulator : IEnumerable 
    {
        string [] moves = {"5","3","1","6","7"};

        public IEnumerator GetEnumerator ( ) 
        {
            foreach( string element in moves )
                yield return element;
        }
    }
    // The Subject runs in a thread and changes its state
    // independently. At each change, it notifies its Observers.
    public class Subject
    {
        public delegate void Callback(string s);

        public event Callback Notify;

        Simulator simulator = new Simulator();
        const int speed = 200;
        public string SubjectState { get; set; }

        public void Go()
        {
            new Thread(new ThreadStart(Run)).Start();
        }

        void Run()
        {
            foreach (string s in simulator)
            {
                Console.WriteLine("Subject: " + s);
                SubjectState = s;
                Notify(s);
                Thread.Sleep(speed); // milliseconds
            }
        }
    }
}