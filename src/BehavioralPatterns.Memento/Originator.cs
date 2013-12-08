using System;
using System.Collections;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;

namespace BehavioralPatterns.Memento
{
    /// <summary>
    /// The chessboard with pieces on it
    /// </summary>
    [Serializable()]
    public class Originator
    {
        List<string> state = new List<string>();

        public void Operation(string s)
        {
            state.Add(s);
            foreach (string line in state)
                Console.WriteLine(line);
            Console.WriteLine("=======================");
        }

        // The reference to the memento is passed back to the client
        public Memento SetMemento()
        {
            Memento memento = new Memento();
            return memento.Save(state);
        }

        public void GetMemento(Memento memento)
        {
            state = (List<string>)memento.Restore();
        }
    }
}
