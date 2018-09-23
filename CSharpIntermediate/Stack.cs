using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharpIntermediate
{
    public class Stack
    {
        private readonly List<object> _list = new List<object>();

        public void Push(object obj)
        {
            if(obj == null)
                throw new InvalidOperationException("You cannot add a null object to the stack");

            _list.Add(obj);
            Console.WriteLine("{0} added to stack", obj);
        }

        public object Pop()
        {
            if (_list.Count == 0)
                throw new InvalidOperationException("There is no element in the stack yet!");

            var index = _list.Count - 1;

            var popper = _list[index];
            _list.RemoveAt(index);
            return popper;
        }

        public void Clear()
        {
            if (_list.Count == 0)
                throw new InvalidOperationException("Cannot clear an empty stack!");

            _list.Clear();
            Console.WriteLine("All elements cleared from stack");
        }

        public object TopElement()
        {
            return _list.Count == 0 ? throw new InvalidOperationException("No element in the stack"): _list[_list.Count - 1];
        }
    }
}