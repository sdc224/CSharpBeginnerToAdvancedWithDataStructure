using System;
namespace DataStructuresAndAlgorithms.DataStructures.StackAndQueue.Queue
{
    public class QueueLinkedList<TData>
    {
        private Node<TData> _frontNode;
        private Node<TData> _rearNode;

        public QueueLinkedList()
        {
            _frontNode = _rearNode = null;
        }

        private bool IsEmpty() => _frontNode == null;

        public int Size()
        {
            var size = 0;
            var currentNode = _frontNode;

            while (currentNode != null)
            {
                size++;
                currentNode = currentNode.Link;
            }

            return size;
        }

        public void Enqueue(TData data)
        {
            var newNode = new Node<TData>(data);

            if (_frontNode == null)
                _frontNode = newNode;
            else
                _rearNode.Link = newNode;

            _rearNode = newNode;
        }

        public TData Dequeue()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Queue underflow!");

            var dequeuedElement = _frontNode.Data;
            _frontNode = _frontNode.Link;

            return dequeuedElement;
        }

        public TData FrontElement()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Queue underflow!");

            return _frontNode.Data;
        }

        public TData RearElement()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Queue underflow!");

            return _rearNode.Data;
        }

        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty!");
                return;
            }

            var currentNode = _frontNode;

            Console.Write("Queue has: ");
            while (currentNode != null)
            {
                Console.Write(currentNode.Data + " ");
                currentNode = currentNode.Link;
            }

            Console.WriteLine();
        }
    }
}
