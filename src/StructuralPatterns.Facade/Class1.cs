using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StructuralPatterns.Facade.Library
{
    internal class SubsystemA
    {
        internal string A1()
        {
            return "Subsystem A, Method A1\n";
        }
        internal string A2()
        {
            return "Subsystem A, Method A2\n";
        }
    }
    internal class SubsystemB
    {
        internal string B1()
        {
            return "Subsystem B, Method B1\n";
        }
    }
    internal class SubsystemC
    {
        internal string C1()
        {
            return "Subsystem C, Method C1\n";
        }
    }
}
