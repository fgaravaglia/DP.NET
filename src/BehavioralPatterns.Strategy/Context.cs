using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BehavioralPatterns.Strategy
{
    public class Context
    {
        // Context state
        public const int start = 5;
        public int Counter = 5;

        // Strategy aggregation
        IStrategy strategy = new Strategy1();

        // Algorithm invokes a strategy method
        public int Algorithm()
        {
            return strategy.Move(this);
        }

        // Changing strategies
        public void SwitchStrategy()
        {

            if (strategy is Strategy1)
            {
                Console.WriteLine(" > Switch Strategy 1 => 2");
                strategy = new Strategy2();
            }
            else
            {
                Console.WriteLine(" > Switch Strategy 2 => 1");
                strategy = new Strategy1();
            }
        }
    }
}