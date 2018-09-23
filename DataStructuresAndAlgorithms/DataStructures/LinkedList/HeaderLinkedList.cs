using System;

namespace DataStructuresAndAlgorithms.DataStructures.LinkedList
{
    public class HeaderLinkedList<TData> where TData : IComparable
    {
        private readonly Node<TData> _head;

        public HeaderLinkedList()
        {
            _head = new Node<TData>();
        }

        public void DisplayList()
        {
            if (_head.Link == null)
            {
                Console.WriteLine("List is empty!");
                return;
            }

            var currentNode = _head.Link;

            Console.Write("List is: ");

            while (currentNode != null)
            {
                Console.Write(currentNode.Data + " ");
                currentNode = currentNode.Link;
            }

            Console.WriteLine();
        }

        public void InsertIfListIsEmpty(TData data)
        {
            if (_head.Link != null)
                return;

            var newNode = new Node<TData>(data);
            _head.Link = newNode;
        }

        public void InsertAtBeginning(TData data)
        {
            if (_head.Link == null)
            {
                InsertIfListIsEmpty(data);
                return;
            }

            var newNode = new Node<TData>
            {
                Data = data,
                Link = _head.Link
            };
            _head.Link = newNode;
        }

        // Benefit: No special cases like empty list is required
        public void InsertAtEnd(TData data)
        {
            var newNode = new Node<TData>(data);

            var currentNode = _head;

            while (currentNode.Link != null)
                currentNode = currentNode.Link;

            currentNode.Link = newNode;
            newNode.Link = null;
        }

        public void InsertBefore(TData data)
        {
            Console.Write("Enter the value before which you want to insert: ");
            var nodeValue = (TData)Convert.ChangeType(Console.ReadLine(), typeof(TData));

            var currentNode = _head;

            while (currentNode.Link != null)
            {
                if (currentNode.Link.Data.CompareTo(nodeValue) == 0)
                    break;

                currentNode = currentNode.Link;
            }

            if (currentNode.Link == null)
            {
                Console.WriteLine($"Node with value {nodeValue} is not present in the list.");
            }

            else
            {
                var newNode = new Node<TData>(data) { Link = currentNode.Link };
                currentNode.Link = newNode;
            }
        }

        public void InsertAtPosition(TData data)
        {
            Console.Write("Enter the position where you want to insert: ");
            var position = Convert.ToInt32(Console.ReadLine());

            if (position > 0)
            {
                int i;
                var currentNode = _head;

                for (i = 1; i <= position - 1 && currentNode != null; i++)
                    currentNode = currentNode.Link;

                if (currentNode == null)
                {
                    Console.WriteLine($"You can insert only upto {i - 1}th position");
                }

                else
                {
                    var newNode = new Node<TData>
                    {
                        Data = data,
                        Link = currentNode.Link
                    };
                    currentNode.Link = newNode;
                }
            }

            else
            {
                Console.WriteLine("Sorry, you cannot insert at this position :(");
            }
        }

        public void DeleteNode(TData data)
        {
            var currentNode = _head;

            while (currentNode.Link != null)
            {
                if (currentNode.Link.Data.CompareTo(data) == 0)
                    break;

                currentNode = currentNode.Link;
            }

            if (currentNode.Link == null)
                Console.WriteLine($"Node with value {data} is not present in the list.");

            else
                currentNode.Link = currentNode.Link.Link;
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

        public void ReverseList()
        {
            if (_head.Link?.Link == null)
                return;

            Node<TData> previousNode = null;
            var currentNode = _head.Link;

            while (currentNode != null)
            {
                var nextNode = currentNode.Link;
                currentNode.Link = previousNode;
                previousNode = currentNode;
                currentNode = nextNode;
            }

            _head.Link = previousNode;
        }
    }
}