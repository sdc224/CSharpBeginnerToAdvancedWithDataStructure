using System;

namespace DataStructuresAndAlgorithms.DataStructures.LinkedList
{
    public class SortedLinkedList<TData> where TData : IComparable
    {
        private Node<TData> _startNode;

        public SortedLinkedList()
        {
            _startNode = null;
        }

        public void InsertInOrder(TData data)
        {
            var newNode = new Node<TData>(data);

            // Insert In Beginning
            if (_startNode == null || data.CompareTo(_startNode.Data) == -1)
            {
                newNode.Link = _startNode;
                _startNode = newNode;
                return;
            }

            var currentNode = _startNode;

            while (currentNode.Link != null)
            {
                if (currentNode.Link.Data.CompareTo(data) > -1)
                    break;

                currentNode = currentNode.Link;
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
                Console.Write("Enter the element to be inserted: ");
                var data = (TData)Convert.ChangeType(Console.ReadLine(), typeof(TData));
                InsertInOrder(data);
            }
        }

        public void SearchNode(TData data)
        {
            if (_startNode == null)
            {
                Console.WriteLine("List is empty!");
                Console.ReadLine();
                return;
            }

            var currentNode = _startNode;
            var position = 1;

            while (currentNode != null && currentNode.Data.CompareTo(data) < 1)
            {
                if (currentNode.Data.CompareTo(data) == 0)
                    break;

                position++;
                currentNode = currentNode.Link;
            }

            if (currentNode == null || currentNode.Data.CompareTo(data) != 0)
                Console.WriteLine($"Node with value {data} is not found in the list.");

            else
                Console.WriteLine($"Node with value {data} is at position {position}.");

            Console.ReadLine();
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

        public void DeleteNode(TData data)
        {
            if (_startNode == null)
            {
                Console.WriteLine("List is Empty");
                return;
            }

            //Deletion of first node
            if (_startNode.Data.CompareTo(data) == 0)
            {
                _startNode = _startNode.Link;
                return;
            }

            //Deletion in between or at the end
            var currentNode = _startNode;

            while (currentNode.Link != null && currentNode.Link.Data.CompareTo(data) != 0)
            {
                currentNode = currentNode.Link;
            }

            if (currentNode.Link == null)
                Console.WriteLine($"Node with value {data} is not present in the list");

            else
                currentNode.Link = currentNode.Link.Link;
        }
    }
}