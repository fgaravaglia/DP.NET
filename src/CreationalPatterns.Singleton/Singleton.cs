using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CreationalPatterns.Singleton
{
    public class LazySingleton
    {
        // Nested class for lazy instantiation
        class SingletonCreator
        {
            static SingletonCreator() { }
            // Private object instantiated with private constructor
            internal static readonly LazySingleton uniqueInstance = new LazySingleton();
        }

        // Public static property to get the object
        public static LazySingleton UniqueInstances
        {
            get { return SingletonCreator.uniqueInstance; }
        }

    }

    public class Singleton<T> where T : class, new()
    {
        Singleton() { }

        class SingletonCreator
        {
            static SingletonCreator() { }
            // Private object instantiated with private constructor
            internal static readonly T instance = new T();
        }

        public static T UniqueInstance
        {
            get { return SingletonCreator.instance; }
        }
    }
}
