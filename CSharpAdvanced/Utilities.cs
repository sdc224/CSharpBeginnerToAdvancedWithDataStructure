using System;

namespace CSharpAdvanced
{
    public class Utilities
    {
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        //Applying Constraints to a generic method or a class declaration
        //where T : IComparable
        //where T : Product(any class name or interface name)               N.B. No type or struct name
        //where T : struct (value type)
        //where T : new()   (An object with default constructor)

        public T Max<T>(T a, T b) where T : IComparable
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }
}