using System;

namespace DataStructuresAndAlgorithms.DataStructures.LinkedList
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

        public void InsertAtPostition(T data, int position)
        {
            if (position != 0)
            {
                Node<T> temp;
                if (position == 1)
                {
                    temp = new Node<T>(data) { Link = _startNode };
                    _startNode = temp;
                    return;
                }

                var currentNode = _startNode;

                int index;

                // For finding a reference upto position - 1
                for (index = 1; index < position - 1 && currentNode != null; index++)
                    currentNode = currentNode.Link;

                if (currentNode == null)
                    Console.WriteLine($"You can insert only upto {index}th position");
                else
                {
                    temp = new Node<T>(data) { Link = currentNode.Link };
                    currentNode.Link = temp;
                }
            }
            else
            {
                Console.WriteLine($"You cannot insert at {position}th position.");
            }
        }

        public void DeleteFirst()
        {
            if (_startNode == null)
                return;

            _startNode = _startNode.Link;
        }

        public void DeleteLast()
        {
            if (_startNode == null)
                return;

            if (_startNode.Link == null)
            {
                _startNode = null;
                return;
            }

            var currentNode = _startNode;

            while (currentNode.Link.Link == null)
                currentNode = currentNode.Link;

            currentNode.Link = null;
        }

        public void DeleteNode(T data)
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
                Console.WriteLine($"Element {data} is not present in the list");

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
                var data = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
                InsertAtEnd(data);
            }
        }

        public void ReverseList()
        {
            if (_startNode == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            // Optional, but save resource
            if (_startNode.Link == null)
                return;

            Node<T> previousNode = null, currentNode = _startNode;

            while (currentNode != null)
            {
                var nextNode = currentNode.Link;
                currentNode.Link = previousNode;
                previousNode = currentNode;
                currentNode = nextNode;
            }

            _startNode = previousNode;
        }

        public void BubbleSortExchangingData()
        {
            Node<T> end = null;
            bool swapped;

            if (_startNode == null)
            {
                Console.WriteLine("Cannot sort an empty list");
                return;
            }

            do
            {
                swapped = false;

                Node<T> i;
                for (i = _startNode; i.Link != end; i = i.Link)
                {
                    if (i.Data.CompareTo(i.Link.Data) != 1)
                        continue;

                    swapped = true;
                    var temp = i.Data;
                    i.Data = i.Link.Data;
                    i.Link.Data = temp;
                }

                end = i;

            } while (swapped);
        }

        public void BubbleSortExchangingLinks()
        {
            if (_startNode == null)
            {
                Console.WriteLine("Cannot sort an empty list");
                return;
            }

            Node<T> end = null;
            bool swapped;

            do
            {
                swapped = false;

                Node<T> currentNode;
                Node<T> previousNode;

                for (previousNode = currentNode = _startNode;
                    currentNode.Link != end;
                    previousNode = currentNode, currentNode = currentNode.Link)
                {
                    var nextNode = currentNode.Link;

                    if (currentNode.Data.CompareTo(nextNode.Data) != 1)
                        continue;

                    swapped = true;
                    currentNode.Link = nextNode.Link;
                    nextNode.Link = currentNode;

                    if (currentNode != _startNode)
                        previousNode.Link = nextNode;
                    else
                        _startNode = nextNode;

                    var tempNode = currentNode;
                    currentNode = nextNode;
                    nextNode = tempNode;
                }

                end = currentNode;

            } while (swapped);
        }

        public SingleLinkedList<T> MergeList(SingleLinkedList<T> list)
        {
            var mergeList = new SingleLinkedList<T> { _startNode = MergeByExchangingLinks(_startNode, list._startNode) };
            return mergeList;
        }

        private static Node<T> MergeByExchangingData(Node<T> list1, Node<T> list2)
        {
            Node<T> newList;


            if (list1.Data.CompareTo(list2.Data) == -1)
            {
                newList = new Node<T>(list1.Data);
                list1 = list1.Link;
            }

            else
            {
                newList = new Node<T>(list2.Data);
                list2 = list2.Link;
            }

            var currentNode = newList;

            while (list1 != null && list2 != null)
            {
                if (list1.Data.CompareTo(list2.Data) == -1)
                {
                    currentNode.Link = new Node<T>(list1.Data);
                    list1 = list1.Link;
                }

                else
                {
                    currentNode.Link = new Node<T>(list2.Data);
                    list2 = list2.Link;
                }

                currentNode = currentNode.Link;
            }

            while (list1 != null)
            {
                currentNode.Link = new Node<T>(list1.Data);
                list1 = list1.Link;
                currentNode = currentNode.Link;
            }

            while (list2 != null)
            {
                currentNode.Link = new Node<T>(list2.Data);
                list2 = list2.Link;
                currentNode = currentNode.Link;
            }

            return newList;
        }

        private static Node<T> MergeByExchangingLinks(Node<T> list1, Node<T> list2)
        {
            Node<T> startNode = null;

            if (list1.Data.CompareTo(list2.Data) == -1)
            {
                startNode = list1;
                list1 = list1.Link;
            }

            else
            {
                startNode = list2;
                list2 = list2.Link;
            }

            var currentNode = startNode;

            while (list1 != null && list2 != null)
            {
                if (list1.Data.CompareTo(list2.Data) == -1)
                {
                    currentNode.Link = list1;
                    list1 = list1.Link;
                }

                else
                {
                    currentNode.Link = list2;
                    list2 = list2.Link;
                }

                currentNode = currentNode.Link;
            }

            currentNode.Link = list1 ?? list2;

            return startNode;
        }

        public void MergeSort()
        {
            _startNode = MergeSortRecursive(_startNode);
        }

        private static Node<T> MergeSortRecursive(Node<T> startNode)
        {
            if (startNode?.Link == null)
                return startNode;

            var start1 = startNode;
            var start2 = DivideList(startNode);

            start1 = MergeSortRecursive(start1);
            start2 = MergeSortRecursive(start2);

            var sortedList = MergeByExchangingLinks(start1, start2);

            return sortedList;
        }

        private static Node<T> DivideList(Node<T> currentNode)
        {
            var nextNextNode = currentNode.Link.Link;

            while (nextNextNode?.Link != null)
            {
                currentNode = currentNode.Link;
                nextNextNode = nextNextNode.Link.Link;
            }

            var start2 = currentNode.Link;
            currentNode.Link = null;
            return start2;
        }

        public void InsertCycle(T data)
        {
            if (_startNode == null)
                return;

            var currentNode = _startNode;
            Node<T> previousNode = null, nodeForCycle = null;

            while (currentNode != null)
            {
                if (currentNode.Data.CompareTo(data) == 0)
                    nodeForCycle = currentNode;

                previousNode = currentNode;
                currentNode = currentNode.Link;
            }

            if (nodeForCycle != null)
                previousNode.Link = nodeForCycle;

            else
                Console.WriteLine($"Node with data {data} not present in the list.");
        }

        private Node<T> FindCycle()
        {
            if (_startNode?.Link == null)
                return null;

            var fastReference = _startNode;
            var slowReference = _startNode;

            while (fastReference?.Link != null)
            {
                slowReference = slowReference.Link;
                fastReference = fastReference.Link.Link;

                if (slowReference == fastReference)
                    return slowReference;
            }

            return null;
        }

        public void RemoveCycle()
        {
            var nodeContainsCycle = FindCycle();

            if (nodeContainsCycle == null)
                return;

            Console.WriteLine("Node value where cycle is detected is: " + nodeContainsCycle.Data);

            var referenceNode = nodeContainsCycle;
            var movingNode = nodeContainsCycle;
            var lengthOfCycle = 0;

            do
            {
                lengthOfCycle++;
                movingNode = movingNode.Link;

            } while (referenceNode != movingNode);

            var lengthOfRemainingList = 0;
            referenceNode = _startNode;

            while (referenceNode != movingNode)
            {
                lengthOfRemainingList++;
                referenceNode = referenceNode.Link;
                movingNode = movingNode.Link;
            }

            var totalLength = lengthOfRemainingList + lengthOfCycle;

            Console.WriteLine($"Length of the cycle is: {lengthOfCycle}" +
                              $"\nNo of nodes which are not present in the cycle is/are: {lengthOfRemainingList}" +
                              $"\nTotal Length of the list: {totalLength}");

            referenceNode = _startNode;

            for (var i = 1; i < totalLength - 1; i++)
                referenceNode = referenceNode.Link;

            referenceNode.Link = null;
        }

        public bool HasCycle()
        {
            return FindCycle() != null;
        }

        public void Concatenate(SingleLinkedList<T> linkedList)
        {
            if (_startNode == null)
            {
                _startNode = linkedList._startNode;
                return;
            }

            if (linkedList._startNode == null)
                return;

            var currentNode = _startNode;

            while (currentNode.Link != null)
                currentNode = currentNode.Link;

            currentNode.Link = linkedList._startNode;
        }
    }
}