using System;

namespace DataStructuresAndAlgorithms.DataStructures.StackAndQueue.Queue
{
    public class PriorityQueueLinkedList<TData> where TData : IComparable
    {
        private NodePriority<TData> _frontNode;

        // No rear part is required as we will enqueue data based on their priority in Sorted Linked List

        public PriorityQueueLinkedList()
        {
            _frontNode = null;
        }

        private bool IsEmpty() => _frontNode == null;

        public void Enqueue(int elementPriority, TData data)
        {
            var newNode = new NodePriority<TData>(elementPriority, data);

            // Insert In Beginning
            if (IsEmpty() || elementPriority.CompareTo(_frontNode.Priority) == -1)
            {
                newNode.Link = _frontNode;
                _frontNode = newNode;
                return;
            }

            var currentNode = _frontNode;

            while (currentNode.Link != null)
            {
                if (currentNode.Link.Priority.CompareTo(elementPriority) > -1)
                    break;

                currentNode = currentNode.Link;
            }

            newNode.Link = currentNode.Link;
            currentNode.Link = newNode;

        }

        public TData Dequeue()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Queue underflow!");

            var dequeuedElement = _frontNode.Data;
            _frontNode = _frontNode.Link;

            return dequeuedElement;
        }

        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty!");
                return;
            }

            var currentNode = _frontNode;

            Console.WriteLine("Queue has.....\n");
            Console.WriteLine("Element\t\tPriority");

            while (currentNode != null)
            {
                Console.WriteLine("   " + currentNode.Data + "\t\t   " + currentNode.Priority);
                currentNode = currentNode.Link;
            }

            Console.WriteLine();
        }

        public int Size()
        {
            if (IsEmpty())
                return 0;

            var size = 0;
            var currentNode = _frontNode;

            while (currentNode != null)
            {
                size++;
                currentNode = currentNode.Link;
            }

            return size;
        }
    }
}
