using System;

namespace SingleLinkedList
{
    public class SingleLinkedList<T> where T : IComparable
    {
        private Node<T> _startNode;

        public SingleLinkedList()
        {
            _startNode = null;
        }

        public void DisplayList()
        {
            if (_startNode == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            var currentNode = _startNode;

            Console.Write("List is: ");

            while (currentNode != null)
            {
                Console.Write(currentNode.Data + " ");
                currentNode = currentNode.Link;
            }

            Console.Write("NULL\n");
        }

        public int CountNoOfNodes()
        {
            var currentNode = _startNode;
            var noOfNodes = 0;

            while (currentNode != null)
            {
                noOfNodes++;
                currentNode = currentNode.Link;
            }

            return noOfNodes;
        }

        public void SearchNode(T value)
        {
            var currentNode = _startNode;
            var position = 1;

            while (currentNode != null)
            {
                if (currentNode.Data.CompareTo(value) == 0)
                    break;

                position++;
                currentNode = currentNode.Link;
            }

            if (currentNode == null)
                Console.WriteLine(value + " is not found in the list");

            Console.WriteLine(value + " is at position " + position);
        }

        public void InsertAtBeginning(T data)
        {
            var newNode = new Node<T>(data) { Link = _startNode };

            _startNode = newNode;
        }

        public void InsertAtEnd(T data)
        {
            var newNode = new Node<T>(data);

            if (_startNode == null)
            {
                _startNode = newNode;
                return;
            }

            var currentNode = _startNode;

            while (currentNode.Link != null) currentNode = currentNode.Link;

            currentNode.Link = newNode;
        }

        public void InsertAfter(T data, T nodeValue)
        {
            var currentNode = _startNode;

            while (currentNode != null)
            {
                if (currentNode.Data.CompareTo(nodeValue) == 0)
                    break;

                currentNode = currentNode.Link;
            }

            if (currentNode == null)
            {
                Console.WriteLine(nodeValue + " is not present in the list");
                return;
            }

            var newNode = new Node<T>(data) { Link = currentNode.Link };
            currentNode.Link = newNode;
        }

        public void InsertBefore(T data, T nodeValue)
        {
            if (_startNode == null)
            {
                Console.WriteLine("List is Empty");
                return;
            }

            var newNode = new Node<T>(data);

            // If the node is the starting node before which I have to insert 
            if (_startNode.Data.CompareTo(nodeValue) == 0)
            {
                newNode.Link = _startNode;
                _startNode = newNode;
                return;
            }

            var currentNode = _startNode;

            while (currentNode.Link != null)
            {
                if (currentNode.Link.Data.CompareTo(nodeValue) == 0)
                    break;

                currentNode = currentNode.Link;
            }

            if (currentNode.Link == null)
            {
                Console.WriteLine(nodeValue + " is not present in the list");
                return;
            }

            newNode.Link = currentNode.Link;
            currentNode.Link = newNode;
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
                Console.Write("Enter the elements to be inserted: ");
                var data = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
                InsertAtEnd(data);
            }
        }
    }
}