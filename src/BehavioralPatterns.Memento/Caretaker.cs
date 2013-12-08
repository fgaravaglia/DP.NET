using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BehavioralPatterns.Memento
{
    /// <summary>
    /// A checkpoint of the state of the game
    /// </summary>
    public class Caretaker
    {
        public Memento Memento { get; set; }
    }
}
