using System;

namespace DataStructuresAndAlgorithms.DataStructures.StackAndQueue.Queue
{
    public class QueueCircularLinkedList<TData>
    {
        private Node<TData> _rearNode;

        public QueueCircularLinkedList()
        {
            _rearNode = null;
        }

        private bool IsEmpty() => _rearNode == null;

        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty!");
                return;
            }

            var currentNode = _rearNode.Link;

            Console.Write("Queue has: ");
            do
            {
                Console.Write(currentNode.Data + " ");
                currentNode = currentNode.Link;

            } while (currentNode != _rearNode.Link);
        }

        public int Size()
        {
            var size = 0;

            if (IsEmpty())
                return 0;

            var currentNode = _rearNode.Link;

            do
            {
                size++;
                currentNode = currentNode.Link;

            } while (currentNode != _rearNode.Link);

            return size;
        }

        public TData FrontElement()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Queue underflow!");

            return _rearNode.Link.Data;
        }

        public TData RearElement()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Queue underflow!");

            return _rearNode.Data;
        }

        public void Enqueue(TData data)
        {
            var newNode = new Node<TData>(data);

            if (IsEmpty())
            {
                _rearNode = newNode;
                _rearNode.Link = _rearNode;
            }

            else
            {
                newNode.Link = _rearNode.Link;
                _rearNode.Link = newNode;
                _rearNode = newNode;
            }
        }

        public TData Dequeue()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Queue underflow!");

            var dequeuedElement = _rearNode.Link.Data;

            if (_rearNode.Link == _rearNode)
                _rearNode = null;

            else
                _rearNode.Link = _rearNode.Link.Link;

            return dequeuedElement;
        }
    }
}