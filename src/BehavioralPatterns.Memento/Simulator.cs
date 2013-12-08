using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace BehavioralPatterns.Memento
{
    public class Simulator : IEnumerable
    {
        string[] lines = 
        {
         "The curfew tolls the knell of parting day",
         "The lowing herd winds slowly o'er the lea",
         "Uh hum uh hum",
         "*UNDO",
         "The plowman homeward plods his weary way",
         "And leaves the world to darkness and to me."
        };

        public IEnumerator GetEnumerator()
        {
            foreach (string element in lines)
                yield return element;
        }
    }
}
