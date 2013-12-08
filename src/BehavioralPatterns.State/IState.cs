using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BehavioralPatterns.State
{
    public interface IState
    {
        int MoveUp(Context context); 
        int MoveDown(Context context);
    }
}
