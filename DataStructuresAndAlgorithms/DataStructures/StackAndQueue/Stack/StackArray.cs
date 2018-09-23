using System;

namespace DataStructuresAndAlgorithms.DataStructures.StackAndQueue.Stack
{
    public class StackArray<TData>
    {
        public TData[] StackElements;
        private int _top;

        public StackArray()
        {
            StackElements = new TData[10];
            _top = -1;
        }

        public StackArray(int maxSize)
        {
            StackElements = new TData[maxSize];
            _top = -1;
        }

        public int Size() => _top + 1;

        public bool IsEmpty() => _top == -1;

        public bool IsFull() => _top == StackElements.Length - 1;

        public void Push(TData data)
        {
            if (IsFull())
            {
                Console.WriteLine("Stack overflow!");
                return;
            }

            StackElements[++_top] = data;
        }

        public TData Pop()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Stack underflow!");

            var poppedElement = StackElements[_top--];
            return poppedElement;
        }

        public TData Peek()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Stack underflow!");

            return StackElements[_top];
        }

        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty!");
                return;
            }

            Console.WriteLine("Stack has ...");

            for (var i = _top; i >= 0; i--)
            {
                Console.WriteLine(StackElements[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
