using DataStructuresAndAlgorithms.DataStructures.StackAndQueue.Queue;
using System;

namespace DataStructuresAndAlgorithms.DataStructures.Tree
{
    public class BinarySearchTree<TData> where TData : IComparable
    {
        private NodeTree<TData> _rootNode;

        public BinarySearchTree()
        {
            _rootNode = null;
        }

        public bool IsEmpty() => _rootNode == null;

        public void InsertRecursive(TData data)
        {
            _rootNode = InsertRecursive(_rootNode, data);
        }

        private NodeTree<TData> InsertRecursive(NodeTree<TData> rootNode, TData data)
        {
            if (rootNode == null)
                rootNode = new NodeTree<TData>(data);

            else if (data.CompareTo(_rootNode.Data) == -1)
                rootNode.LeftChild = InsertRecursive(rootNode, data);

            else if (data.CompareTo(rootNode.Data) == 1)
                rootNode.RightChild = InsertRecursive(rootNode, data);

            else
                Console.WriteLine($"{data} is already present in the tree!");

            return rootNode;
        }

        public void InsertIterative(TData data)
        {
            var currentNode = _rootNode;
            NodeTree<TData> parentNode = null;

            while (currentNode != null)
            {
                parentNode = currentNode;

                if (data.CompareTo(currentNode.Data) == -1)
                    currentNode = currentNode.LeftChild;

                else if (data.CompareTo(currentNode.Data) == 1)
                    currentNode = currentNode.RightChild;

                else
                {
                    Console.WriteLine($"{data} is already present in the tree!");
                    return;
                }
            }

            var newNode = new NodeTree<TData>(data);

            if (parentNode == null)
                _rootNode = newNode;

            else if (data.CompareTo(parentNode.Data) == -1)
                parentNode.LeftChild = newNode;

            else
                parentNode.RightChild = newNode;
        }

        public bool SearchRecursive(TData data) => SearchRecursive(_rootNode, data) != null;

        private NodeTree<TData> SearchRecursive(NodeTree<TData> rootNode, TData data)
        {
            if (rootNode == null)
                return null;

            if (data.CompareTo(rootNode.Data) == -1)
                return SearchRecursive(rootNode.LeftChild, data);

            if (data.CompareTo(rootNode.Data) == 1)
                return SearchRecursive(rootNode.RightChild, data);

            return rootNode;
        }

        public bool SearchIterative(TData data)
        {
            var currentNode = _rootNode;

            while (currentNode != null)
            {
                if (data.CompareTo(currentNode.Data) == -1)
                    currentNode = currentNode.LeftChild;

                else if (data.CompareTo(currentNode.Data) == 1)
                    currentNode = currentNode.RightChild;

                else
                    return true;
            }

            return false;
        }

        public void DeleteRecursive(TData data) => _rootNode = DeleteRecursive(_rootNode, data);

        private NodeTree<TData> DeleteRecursive(NodeTree<TData> rootNode, TData data)
        {
            if (rootNode == null)
            {
                Console.WriteLine($"{data} not found!");
                return null;
            }

            if (data.CompareTo(rootNode.Data) == -1)
                rootNode.LeftChild = DeleteRecursive(rootNode.LeftChild, data);

            else if (data.CompareTo(rootNode.Data) == 1)
                rootNode.RightChild = DeleteRecursive(rootNode.RightChild, data);

            else
            {
                // Key to be deleted is found

                // Case 1: For two children
                if (rootNode.LeftChild != null && rootNode.RightChild != null)
                {
                    var successorNode = rootNode.RightChild;

                    while (successorNode.LeftChild != null)
                        successorNode = successorNode.LeftChild;

                    rootNode.Data = successorNode.Data;
                    rootNode.RightChild = DeleteRecursive(rootNode.RightChild, successorNode.Data);
                }

                // Case 2: For one or no child
                else
                {
                    // For only left child
                    var childNode = rootNode.LeftChild ?? rootNode.RightChild;

                    rootNode = childNode;
                }
            }

            return rootNode;
        }

        public void DeleteIterative(TData data)
        {
            var currentNode = _rootNode;
            NodeTree<TData> parentNode = null;

            while (currentNode != null)
            {
                if (data.CompareTo(currentNode.Data) == 0)
                    break;

                parentNode = currentNode;

                currentNode = data.CompareTo(currentNode.Data) == -1
                    ? currentNode.LeftChild
                    : currentNode.RightChild;
            }

            if (currentNode == null)
            {
                Console.WriteLine($"{data} is not found in the tree!");
                return;
            }

            // Case 1 : Two Children
            // Find Inorder successor and its parent

            if (currentNode.LeftChild != null && currentNode.RightChild != null)
            {
                var parentOfSuccessorNode = currentNode;
                var successorNode = currentNode.RightChild;

                while (successorNode.LeftChild != null)
                {
                    parentOfSuccessorNode = successorNode;
                    successorNode = successorNode.LeftChild;
                }

                currentNode.Data = successorNode.Data;
                currentNode = successorNode;
                parentNode = parentOfSuccessorNode;
            }

            // Case 2 : One or no child

            // Node to be deleted has may be left/right child
            var childNode = currentNode.LeftChild ?? currentNode.RightChild;

            // Node to be deleted is root node
            if (parentNode == null)
                _rootNode = childNode;

            // Node is left child of its parent
            else if (currentNode == parentNode.LeftChild)
                parentNode.LeftChild = childNode;

            // Node is right child of its parent (or leaf node)
            else
                parentNode.RightChild = childNode;
        }

        public TData MinRecursive()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Tree is empty!");

            return MinRecursive(_rootNode).Data;
        }

        public NodeTree<TData> MinRecursive(NodeTree<TData> rootNode)
        {
            return rootNode.LeftChild == null ? rootNode : MinRecursive(rootNode.LeftChild);
        }

        public TData MaxRecursive()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Tree is empty!");

            return MaxRecursive(_rootNode).Data;
        }

        public NodeTree<TData> MaxRecursive(NodeTree<TData> rootNode)
        {
            return rootNode.RightChild == null ? rootNode : MaxRecursive(rootNode.RightChild);
        }

        public TData MinIterative()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Tree is empty!");

            var currentNode = _rootNode;

            while (currentNode.LeftChild != null)
                currentNode = currentNode.LeftChild;

            return currentNode.Data;
        }

        private TData MaxIterative()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Tree is empty!");

            var currentNode = _rootNode;

            while (currentNode.RightChild != null)
                currentNode = currentNode.RightChild;

            return currentNode.Data;
        }

        public void Display()
        {
            Display(_rootNode, 0);
            Console.WriteLine();
        }

        private void Display(NodeTree<TData> rootNode, int level)
        {
            if (rootNode == null)
                return;

            Display(rootNode.RightChild, level + 1);
            Console.WriteLine();

            for (int i = 0; i < level; i++)
                Console.WriteLine("   ");

            Console.WriteLine(rootNode.Data);

            Display(rootNode.LeftChild, level + 1);
        }

        public void PreOrderTraversal()
        {
            PreOrderTraversal(_rootNode);
            Console.WriteLine();
        }

        private void PreOrderTraversal(NodeTree<TData> rootNode)
        {
            if (rootNode == null)
                return;

            Console.WriteLine(rootNode.Data + " ");

            PreOrderTraversal(rootNode.LeftChild);
            PreOrderTraversal(rootNode.RightChild);
        }

        public void InOrderTraversal()
        {
            InOrderTraversal(_rootNode);
            Console.WriteLine();
        }

        private void InOrderTraversal(NodeTree<TData> rootNode)
        {
            if (rootNode == null)
                return;

            InOrderTraversal(_rootNode.LeftChild);

            Console.WriteLine(rootNode.Data + " ");

            InOrderTraversal(rootNode.RightChild);
        }

        public void PostOrderTraversal()
        {
            PostOrderTraversal(_rootNode);
            Console.WriteLine();
        }

        private void PostOrderTraversal(NodeTree<TData> rootNode)
        {
            if (rootNode == null)
                return;

            PostOrderTraversal(rootNode.LeftChild);
            PostOrderTraversal(rootNode.RightChild);

            Console.WriteLine(rootNode.Data + " ");
        }

        public void LevelOrderTraversal()
        {
            if (_rootNode == null)
            {
                Console.WriteLine("Tree is empty!");
                return;
            }

            var queue = new QueueLinkedList<NodeTree<TData>>();
            queue.Enqueue(_rootNode);

            while (queue.Size() != 0)
            {
                var dequeuedElement = queue.Dequeue();

                Console.WriteLine(dequeuedElement.Data);

                if (dequeuedElement.LeftChild != null)
                    queue.Enqueue(dequeuedElement.LeftChild);

                if (dequeuedElement.RightChild != null)
                    queue.Enqueue(dequeuedElement.RightChild);
            }

            Console.WriteLine();
        }

        public int Height() => Height(_rootNode);

        private int Height(NodeTree<TData> rootNode)
        {
            if (rootNode == null)
                return 0;

            var heightOfLeftSubtree = Height(rootNode.LeftChild);
            var heightOfRightSubtree = Height(rootNode.RightChild);

            if (heightOfLeftSubtree > heightOfRightSubtree)
                return 1 + heightOfLeftSubtree;

            return 1 + heightOfRightSubtree;
        }
    }
}
