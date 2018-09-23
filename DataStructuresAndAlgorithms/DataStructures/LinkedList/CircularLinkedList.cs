using System;

namespace DataStructuresAndAlgorithms.DataStructures.LinkedList
{
    public class CircularLinkedList<TData> where TData : IComparable
    {
        private Node<TData> _lastNode;

        public CircularLinkedList()
        {
            _lastNode = null;
        }

        public void DisplayList()
        {
            if (_lastNode == null)
            {
                Console.WriteLine("List is Empty!");
                return;
            }

            var currentNode = _lastNode.Link;
            Console.Write("List has: ");
            do
            {
                Console.Write($"{currentNode.Data} ");
                currentNode = currentNode.Link;

            } while (currentNode != _lastNode.Link);

            Console.WriteLine();
        }

        public void CreateList()
        {
            int i;

            Console.Write("Enter the number of nodes to insert: ");
            var n = Convert.ToInt32(Console.ReadLine());

            if (n == 0)
                return;

            for (i = 0; i < n; i++)
            {
                Console.Write("Enter the element to be inserted: ");
                var data = (TData)Convert.ChangeType(Console.ReadLine(), typeof(TData));
                InsertAtEnd(data);
            }
        }

        public void InsertIfListIsNull(TData data)
        {
            var newNode = new Node<TData>(data);
            _lastNode = newNode;
            _lastNode.Link = _lastNode;
        }

        public void InsertAtBeginning(TData data)
        {
            var newNode = new Node<TData> { Data = data, Link = _lastNode.Link };
            _lastNode.Link = newNode;
        }

        public void InsertAtEnd(TData data)
        {
            if (_lastNode == null)
            {
                InsertIfListIsNull(data);
                return;
            }

            var newNode = new Node<TData> { Data = data, Link = _lastNode.Link };
            _lastNode.Link = newNode;
            _lastNode = newNode;
        }

        public void InsertBefore(TData data)
        {
            if (_lastNode == null)
            {
                InsertIfListIsNull(data);
                return;
            }

            Console.Write("Enter the value of the node before which you want to insert: ");
            var nodeValue = Convert.ChangeType(Console.ReadLine(), typeof(TData));

            var currentNode = _lastNode.Link;

            do
            {
                if (currentNode.Link.Data.CompareTo(nodeValue) == 0)
                    break;

                currentNode = currentNode.Link;

            } while (currentNode != _lastNode.Link);

            if (currentNode == _lastNode.Link && currentNode.Data.CompareTo(nodeValue) != 0)
                Console.WriteLine($"Node with value {nodeValue} is not present in the list.");

            else
            {
                var newNode = new Node<TData> { Data = data, Link = currentNode.Link };
                currentNode.Link = newNode;
            }
        }

        public void InsertAfter(TData data)
        {
            if (_lastNode == null)
            {
                InsertIfListIsNull(data);
                return;
            }

            Console.Write("Enter the value of the node after which you want to insert: ");
            var nodeValue = (TData)Convert.ChangeType(Console.ReadLine(), typeof(TData));

            var currentNode = _lastNode.Link;

            do
            {
                if (currentNode.Data.CompareTo(nodeValue) == 0)
                    break;

                currentNode = currentNode.Link;
            } while (currentNode != _lastNode.Link);

            if (currentNode == _lastNode.Link && currentNode.Data.CompareTo(nodeValue) != 0)
            {
                Console.WriteLine($"Node with value {nodeValue} is not present in the list.");
                return;
            }

            var newNode = new Node<TData> { Data = data, Link = currentNode.Link };
            currentNode.Link = newNode;

            if (currentNode == _lastNode)
                _lastNode = newNode;
        }

        public void InsertAtPosition(TData data)
        {
            if (_lastNode == null)
            {
                InsertIfListIsNull(data);
                return;
            }

            Console.Write("Enter the position where you want to insert: ");
            var position = Convert.ToInt32(Console.ReadLine());

            if (position != 0)
            {
                if (position != 0)
                {
                    Node<TData> temp;
                    if (position == 1)
                    {
                        temp = new Node<TData>(data) { Link = _lastNode };
                        _lastNode = temp;
                        return;
                    }

                    var currentNode = _lastNode.Link;

                    int index;

                    // For finding a reference upto position - 1
                    for (index = 1; index < position - 1 && currentNode != null; index++)
                        currentNode = currentNode.Link;

                    if (currentNode == null)
                        Console.WriteLine($"You can insert only upto {index}th position");
                    else
                    {
                        temp = new Node<TData>(data) { Link = currentNode.Link };
                        currentNode.Link = temp;
                    }
                }
                else
                {
                    Console.WriteLine($"You cannot insert at {position}th position.");
                }

            }
        }

        public void DeleteFirst()
        {
            if (_lastNode?.Link == null)
            {
                _lastNode = null;
                return;
            }

            _lastNode.Link = _lastNode.Link.Link;
        }

        public void DeleteLast()
        {
            if (_lastNode?.Link == null)
            {
                _lastNode = null;
                return;
            }

            var predecessorNode = _lastNode.Link;

            while (predecessorNode.Link != _lastNode)
                predecessorNode = predecessorNode.Link;

            predecessorNode.Link = _lastNode.Link;
            _lastNode = predecessorNode;
        }

        public void DeleteNode(TData data)
        {
            if (_lastNode == null)
            {
                Console.WriteLine("List is empty, cannot delete");
                Console.ReadLine();
                return;
            }

            if (_lastNode.Link == _lastNode && _lastNode.Data.CompareTo(data) == 0)
            {
                _lastNode = null;
                return;
            }

            if (_lastNode.Link != _lastNode && _lastNode.Link.Data.CompareTo(data) == 0)
            {
                _lastNode.Link = _lastNode.Link.Link;
                return;
            }

            var predecessorNode = _lastNode.Link;

            while (predecessorNode != null && predecessorNode.Link != _lastNode.Link)
            {
                if (predecessorNode.Link.Data.CompareTo(data) == 0)
                    break;

                predecessorNode = predecessorNode.Link;
            }

            if (predecessorNode != null && predecessorNode.Link == _lastNode.Link)
                Console.WriteLine($"Node with value {data} is not present in the list.");

            else
            {
                if (predecessorNode == null)
                    return;

                predecessorNode.Link = predecessorNode.Link.Link;

                if (_lastNode.Data.CompareTo(data) == 0)
                    _lastNode = predecessorNode;
            }
        }

        public void Concatenate(CircularLinkedList<TData> circularLinkedList)
        {
            if (_lastNode == null)
            {
                _lastNode = circularLinkedList._lastNode;
                return;
            }

            if (circularLinkedList._lastNode == null)
                return;

            var currentNode = _lastNode.Link;
            _lastNode.Link = circularLinkedList._lastNode.Link;
            circularLinkedList._lastNode.Link = currentNode;
            _lastNode = circularLinkedList._lastNode;
        }
    }
}