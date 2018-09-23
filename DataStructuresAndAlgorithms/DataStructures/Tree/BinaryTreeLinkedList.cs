using DataStructuresAndAlgorithms.DataStructures.StackAndQueue.Queue;
using System;

namespace DataStructuresAndAlgorithms.DataStructures.Tree
{
    public class BinaryTreeLinkedList<TData>
    {
        private readonly NodeTree<TData> _rootNode;

        public BinaryTreeLinkedList()
        {
            _rootNode = null;
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
