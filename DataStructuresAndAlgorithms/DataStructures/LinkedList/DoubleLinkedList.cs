using System;

namespace DataStructuresAndAlgorithms.DataStructures.LinkedList
{
    public class DoubleLinkedList<TData> where TData : IComparable
    {
        private NodeDoubleLink<TData> _startNode;

        public DoubleLinkedList()
        {
            _startNode = null;
        }

        public void DisplayList()
        {
            if (_startNode == null)
            {
                Console.WriteLine("List is empty!");
                return;
            }

            var currentLink = _startNode;

            Console.Write("List is: ");
            while (currentLink != null)
            {
                Console.Write(currentLink.Data + " ");
                currentLink = currentLink.NextLink;
            }

            Console.WriteLine();
        }

        public void InsertIfListIsNull(TData data)
        {
            var tempNode = new NodeDoubleLink<TData>(data);
            _startNode = tempNode;
        }

        public void InsertAtBeginning(TData data)
        {
            var tempNode = new NodeDoubleLink<TData>(data) { NextLink = _startNode };
            _startNode.PreviousLink = tempNode;

            _startNode = tempNode;
        }

        public void InsertAtEnd(TData data)
        {
            if (_startNode == null)
            {
                InsertIfListIsNull(data);
                return;
            }

            var currentNode = _startNode;

            while (currentNode.NextLink != null)
                currentNode = currentNode.NextLink;

            var tempNode = new NodeDoubleLink<TData>(data);
            currentNode.NextLink = tempNode;
            tempNode.PreviousLink = currentNode;
        }

        public void InsertAfter(TData data)
        {
            if (_startNode == null)
            {
                InsertIfListIsNull(data);
                return;
            }

            Console.Write("Enter the element after which you want to insert");
            var nodeValue = (TData)Convert.ChangeType(Console.ReadLine(), typeof(TData));

            var currentNode = _startNode;

            while (currentNode != null)
            {
                if (currentNode.Data.CompareTo(nodeValue) == 0)
                    break;

                currentNode = currentNode.NextLink;
            }

            if (currentNode == null)
                Console.WriteLine($"Node with value {nodeValue} is not present in the list.");

            else
            {
                var tempNode = new NodeDoubleLink<TData>(data) { NextLink = currentNode.NextLink, PreviousLink = currentNode };
                if (currentNode.NextLink != null)
                    currentNode.NextLink.PreviousLink = tempNode;

                currentNode.NextLink = tempNode;
            }
        }

        public void InsertBefore(TData data)
        {
            if (_startNode == null)
            {
                InsertIfListIsNull(data);
                return;
            }

            Console.Write("Enter the element before which you want to insert");
            var nodeValue = (TData)Convert.ChangeType(Console.ReadLine(), typeof(TData));

            var currentNode = _startNode;

            while (currentNode.NextLink != null)
            {
                if (currentNode.NextLink.Data.CompareTo(nodeValue) == 0)
                    break;

                currentNode = currentNode.NextLink;
            }

            if (currentNode.NextLink == null)
            {
                Console.WriteLine($"Node with value {nodeValue} is not present in the list");
                return;
            }

            var tempNode = new NodeDoubleLink<TData>
            {
                Data = data,
                NextLink = currentNode.NextLink,
                PreviousLink = currentNode
            };
            currentNode.NextLink.PreviousLink = tempNode;
            currentNode.NextLink = tempNode;
        }

        public void CreateList()
        {
            Console.Write("Enter the number of nodes you want to insert: ");
            var noOfNodes = Convert.ToInt32(Console.ReadLine());

            if (noOfNodes == 0)
                return;

            for (var i = 0; i < noOfNodes; i++)
            {
                Console.Write("Enter the element to be inserted: ");
                var data = (TData)Convert.ChangeType(Console.ReadLine(), typeof(TData));
                InsertAtEnd(data);
            }
        }

        public void InsertAtPosition(TData data)
        {
            if (_startNode == null)
            {
                InsertIfListIsNull(data);
                return;
            }

            Console.Write("Enter the position where you want to insert: ");
            var position = Convert.ToInt32(Console.ReadLine());

            if (position == 0)
                return;

            if (position == 1)
            {
                InsertAtBeginning(data);
                return;
            }

            int index;
            var currentNode = _startNode;

            for (index = 1; index < position - 1 && currentNode != null; index++)
            {
                currentNode = currentNode.NextLink;
            }

            if (currentNode == null)
                Console.WriteLine($"You can insert only upto {index}th position.");
            else
            {
                var newNode = new NodeDoubleLink<TData>
                {
                    Data = data,
                    NextLink = currentNode.NextLink,
                    PreviousLink = currentNode
                };

                if (currentNode.NextLink != null)
                    currentNode.NextLink.PreviousLink = newNode;

                currentNode.NextLink = newNode;
            }
        }

        public void DeleteFirst()
        {
            if (_startNode == null)
                return;

            if (_startNode.NextLink != null)
            {
                _startNode = _startNode.NextLink;
                _startNode.PreviousLink = null;

                return;
            }

            _startNode = null;
        }

        public void DeleteLast()
        {
            if (_startNode?.NextLink == null)
            {
                _startNode = null;
                return;
            }

            var currentNode = _startNode;

            while (currentNode.NextLink.NextLink != null)
            {
                currentNode = currentNode.NextLink;
            }

            currentNode.NextLink = null;
        }

        public void DeleteNode(TData data)
        {
            if (_startNode.Data.CompareTo(data) == 0)
            {
                DeleteFirst();
                return;
            }

            var currentNode = _startNode.NextLink;

            while (currentNode != null && currentNode.Data.CompareTo(data) != 0)
                currentNode = currentNode.NextLink;

            if (currentNode == null)
                Console.WriteLine($"Node with value {data} is not present in the list.");

            else
            {
                currentNode.PreviousLink.NextLink = currentNode.NextLink;

                if (currentNode.NextLink != null)
                {
                    currentNode.NextLink.PreviousLink = currentNode.PreviousLink;
                }
            }
        }

        public void ReverseList()
        {
            if (_startNode?.NextLink == null)
                return;

            var currentNode = _startNode;
            var nextNode = currentNode.NextLink;
            currentNode.NextLink = null;
            currentNode.PreviousLink = nextNode;

            while (nextNode != null)
            {
                nextNode.PreviousLink = nextNode.NextLink;
                nextNode.NextLink = currentNode;
                currentNode = nextNode;
                nextNode = nextNode.PreviousLink;
            }

            _startNode = currentNode;
        }
    }
}