using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BehavioralPatterns.State
{
    // State 1
    public class NormalState : IState 
    {
        public int MoveUp(Context context) 
        {
            context.Counter+=2;
            return context.Counter;
        }

         public int MoveDown(Context context) 
         {
             if (context.Counter < Context.limit) 
             {
                 context.State = new FastState( );
                 Console.Write("|| ");
             }
             context.Counter-=2;
             return context.Counter;
         }
    }

     // State 2
    public class FastState : IState
    {
        public int MoveUp(Context context)
        {
            context.Counter += 5;
            return context.Counter;
        }

        public int MoveDown(Context context)
        {
            if (context.Counter < Context.limit)
            {
                context.State = new NormalState();
                Console.Write("||");
            }
            context.Counter -= 5;
            return context.Counter;
        }
    }
 }