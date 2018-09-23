using System;

namespace DataStructuresAndAlgorithms.DataStructures.StackAndQueue.Stack
{
    public class StackLinkedList<TData>
    {
        private Node<TData> _topNode;

        public StackLinkedList()
        {
            _topNode = null;
        }

        private bool IsEmpty() => _topNode == null;

        public int Size()
        {
            var size = 0;
            var currentNode = _topNode;

            while (currentNode != null)
            {
                currentNode = currentNode.Link;
                size++;
            }

            return size;
        }

        public void Push(TData data)
        {
            var newNode = new Node<TData>(data) { Link = _topNode };
            _topNode = newNode;
        }

        public TData Pop()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Stack underflow!");

            var poppedElement = _topNode.Data;
            _topNode = _topNode.Link;

            return poppedElement;
        }

        public TData Peek()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Stack underflow!");

            return _topNode.Data;
        }

        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty!");
                return;
            }

            var currentNode = _topNode;

            Console.WriteLine("Stack has: ");
            while (currentNode != null)
            {
                Console.WriteLine(currentNode.Data);
                currentNode = currentNode.Link;
            }
            Console.WriteLine();
        }
    }
}