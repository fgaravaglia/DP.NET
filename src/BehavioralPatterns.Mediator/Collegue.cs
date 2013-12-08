using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BehavioralPatterns.Mediator
{
    public class Colleague
    {
        Interact visuals;
        string name;

        public Colleague(Mediator mediator, string name)
        {
            this.name = name;
            visuals = new Interact(name);
            mediator.SignOn(name, Receive, visuals);
        }

        public void Receive(string message, string from)
        {
            visuals.Output(from + ": " + message);
        }
    }
}
