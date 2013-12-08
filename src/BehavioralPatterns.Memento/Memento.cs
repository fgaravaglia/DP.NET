using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace BehavioralPatterns.Memento
{
   
    /// Serializes by deep copy to memory and back
    [Serializable()]
    public class Memento
    {
        MemoryStream stream = new MemoryStream();
        BinaryFormatter formatter = new BinaryFormatter();

        public Memento Save(object o)
        {
            formatter.Serialize(stream, o);
            return this;
        }

        public object Restore()
        {
            stream.Seek(0, SeekOrigin.Begin);
            object o = formatter.Deserialize(stream);
            stream.Close();
            return o;
        }
    }
}
