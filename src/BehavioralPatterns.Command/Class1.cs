using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BehavioralPatterns.Command
{
    public delegate void Invoker();

    public class Command
    {
        public Invoker Execute, Undo, Redo;

        public Command(Receiver receiver)
        {
            Execute = receiver.Action;
            Redo = receiver.Action;
            Undo = receiver.Reverse;
        }
    }

    public class Receiver
    {
        string build, oldbuild;
        string s = "some string ";

        public void Action()
        {
            oldbuild = build;
            build += s;
            Console.WriteLine("Receiver > Do Action:");
            Console.WriteLine("\tAdding string: ==> " + build);
        }

        public void Reverse()
        {
            build = oldbuild;
            Console.WriteLine("Receiver > Reverte Action:");
            Console.WriteLine("\tCurrent string: ==> " + build);
        }
    }
}
