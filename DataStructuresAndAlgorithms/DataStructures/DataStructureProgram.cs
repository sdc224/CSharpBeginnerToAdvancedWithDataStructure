using DataStructuresAndAlgorithms.DataStructures.StackAndQueue.Stack;
using System;

namespace DataStructuresAndAlgorithms.DataStructures
{
    internal class DataStructureProgram
    {
        private static void DataStructureMain()
        {
            #region Single Linked List

            /*             
            var softwareUsing = true;

            var singleLinkedList = new SingleLinkedList<int>();

            singleLinkedList.CreateList();

            while (softwareUsing)
            {
                Console.WriteLine("0. Clear the Console");
                Console.WriteLine("1. Display List");
                Console.WriteLine("2. Count the no of Nodes");
                Console.WriteLine("3. Search for an element");
                Console.WriteLine("4. Insert in beginning of the list");
                Console.WriteLine("5. Insert in end of the list");
                Console.WriteLine("6. Insert before a value");
                Console.WriteLine("7. Insert after a value");
                Console.WriteLine("8. Insert at a position");
                Console.WriteLine("9. Delete first node");
                Console.WriteLine("10. Delete last node");
                Console.WriteLine("11. Delete a node with value");
                Console.WriteLine("12. Reverse the list");
                Console.WriteLine("13. Sort the list using Bubble Sort by exchanging data");
                Console.WriteLine("14. Sort the list using Bubble Sort by exchanging links");
                Console.WriteLine("15. Merging two sorted list");
                Console.WriteLine("16. Sort the list using Merge Sort");
                Console.WriteLine("17. Insert cycle");
                Console.WriteLine("18. Detect Cycle");
                Console.WriteLine("19. Remove Cycle");
                Console.WriteLine("20. Concatenate two linked list");

                Console.WriteLine("Any other key to  exit");

                Console.WriteLine("Enter your choice");
                var choice = Convert.ToInt32(Console.ReadLine());

                int data;
                int nodeValue;

                SingleLinkedList<int> list2;
                switch (choice)
                {
                    case 0:
                        Console.Clear();
                        break;

                    case 1:
                        singleLinkedList.DisplayList();
                        break;

                    case 2:
                        Console.WriteLine("No of Nodes: " + singleLinkedList.CountNoOfNodes());
                        break;

                    case 3:
                        Console.WriteLine("Enter the element to be searched: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        singleLinkedList.SearchNode(data);
                        break;

                    case 4:
                        Console.Write("Enter the element to be inserted: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        singleLinkedList.InsertAtBeginning(data);
                        break;

                    case 5:
                        Console.Write("Enter the element to be inserted: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        singleLinkedList.InsertAtEnd(data);
                        break;

                    case 6:
                        Console.WriteLine("Enter the value after which you want to insert: ");
                        nodeValue = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter the element to be inserted: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        singleLinkedList.InsertBefore(data, nodeValue);
                        break;

                    case 7:
                        Console.WriteLine("Enter the value after which you want to insert: ");
                        nodeValue = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter the element to be inserted: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        singleLinkedList.InsertAfter(data, nodeValue);
                        break;

                    case 8:
                        Console.Write("Enter the position where you want to insert: ");
                        var position = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter the element to be inserted: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        singleLinkedList.InsertAtPostition(data, position);
                        break;

                    case 9:
                        singleLinkedList.DeleteFirst();
                        break;

                    case 10:
                        singleLinkedList.DeleteLast();
                        break;

                    case 11:
                        Console.Write("Enter the element to be deleted: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        singleLinkedList.DeleteNode(data);
                        break;

                    case 12:
                        singleLinkedList.ReverseList();
                        break;

                    case 13:
                        singleLinkedList.BubbleSortExchangingData();
                        break;

                    case 14:
                        singleLinkedList.BubbleSortExchangingLinks();
                        break;

                    case 15:
                        list2 = new SingleLinkedList<int>();
                        list2.CreateList();
                        var mergedList = singleLinkedList.MergeList(list2);
                        mergedList.DisplayList();
                        break;

                    case 16:
                        singleLinkedList.MergeSort();
                        Console.WriteLine("After sorting the list using Merge Sort --");
                        singleLinkedList.DisplayList();
                        Console.ReadLine();
                        break;

                    case 17:
                        Console.WriteLine("Enter the node value where you want to insert the cycle");
                        data = Convert.ToInt32(Console.ReadLine());
                        singleLinkedList.InsertCycle(data);
                        Console.WriteLine("Cycle Inserted!");
                        Console.ReadLine();
                        break;

                    case 18:
                        Console.WriteLine(singleLinkedList.HasCycle()
                            ? "List has a cycle."
                            : "List has not any cycle.");

                        break;

                    case 19:
                        singleLinkedList.RemoveCycle();
                        Console.WriteLine("Cycle has been removed...");
                        Console.ReadLine();
                        break;

                    case 20:
                        Console.WriteLine("Enter details of second list....");
                        list2 = new SingleLinkedList<int>();
                        list2.CreateList();
                        singleLinkedList.Concatenate(list2);
                        break;

                    default:
                        Console.WriteLine("Thank you for using my software :)");
                        softwareUsing = false;
                        break;
                }
            }
            */

            #endregion

            #region Double Linked List
            /*             
            var softwareUsing = true;

            var doubleLinkedList = new DoubleLinkedList<int>();

            doubleLinkedList.CreateList();

            while (softwareUsing)
            {
                Console.WriteLine("0. Clear the Console");
                Console.WriteLine("1. Display List");
                Console.WriteLine("2. Count the no of Nodes");
                Console.WriteLine("3. Search for an element");
                Console.WriteLine("4. Insert in beginning of the list");
                Console.WriteLine("5. Insert in end of the list");
                Console.WriteLine("6. Insert before a value");
                Console.WriteLine("7. Insert after a value");
                Console.WriteLine("8. Insert at a position");
                Console.WriteLine("9. Delete first node");
                Console.WriteLine("10. Delete last node");
                Console.WriteLine("11. Delete a node with value");
                Console.WriteLine("12. Reverse the list");

                Console.WriteLine("Any other key to  exit");

                Console.WriteLine("Enter your choice");
                var choice = Convert.ToInt32(Console.ReadLine());

                int data;

                switch (choice)
                {
                    case 0:
                        Console.Clear();
                        break;

                    case 1:
                        doubleLinkedList.DisplayList();
                        break;

                    case 2:
                        //Console.WriteLine("No of Nodes: " + doubleLinkedList.CountNoOfNodes());
                        break;

                    case 3:
                        Console.WriteLine("Enter the element to be searched: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        //doubleLinkedList.SearchNode(data);
                        break;

                    case 4:
                        Console.Write("Enter the element to be inserted: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        doubleLinkedList.InsertAtBeginning(data);
                        break;

                    case 5:
                        Console.Write("Enter the element to be inserted: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        doubleLinkedList.InsertAtEnd(data);
                        break;

                    case 6:
                        Console.Write("Enter the element to be inserted: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        doubleLinkedList.InsertBefore(data);
                        break;

                    case 7:
                        Console.Write("Enter the element to be inserted: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        doubleLinkedList.InsertAfter(data);
                        break;

                    case 8:
                        Console.Write("Enter the element to be inserted: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        doubleLinkedList.InsertAtPosition(data);
                        break;

                    case 9:
                        doubleLinkedList.DeleteFirst();
                        break;

                    case 10:
                        doubleLinkedList.DeleteLast();
                        break;

                    case 11:
                        Console.Write("Enter the element to be deleted: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        doubleLinkedList.DeleteNode(data);
                        break;

                    case 12:
                        doubleLinkedList.ReverseList();
                        Console.WriteLine("After reversing");
                        doubleLinkedList.DisplayList();
                        break;

                    default:
                        Console.WriteLine("Thank you for using my software :)");
                        softwareUsing = false;
                        break;
                }
            }
            */

            #endregion

            #region Circular Linked List

            /*
            var softwareUsing = true;

            var circularLinkedList = new CircularLinkedList<int>();

            circularLinkedList.CreateList();

            while (softwareUsing)
            {
                Console.WriteLine("0. Clear the Console");
                Console.WriteLine("1. Display List");
                Console.WriteLine("2. Count the no of Nodes");
                Console.WriteLine("3. Search for an element");
                Console.WriteLine("4. Insert in beginning of the list");
                Console.WriteLine("5. Insert in end of the list");
                Console.WriteLine("6. Insert before a value");
                Console.WriteLine("7. Insert after a value");
                Console.WriteLine("8. Insert at a position");
                Console.WriteLine("9. Delete first node");
                Console.WriteLine("10. Delete last node");
                Console.WriteLine("11. Delete a node with value");
                Console.WriteLine("12. Concatenate two linked list");

                Console.WriteLine("Any other key to  exit");

                Console.WriteLine("Enter your choice");
                var choice = Convert.ToInt32(Console.ReadLine());

                int data;

                switch (choice)
                {
                    case 0:
                        Console.Clear();
                        break;

                    case 1:
                        circularLinkedList.DisplayList();
                        break;

                    case 2:
                        //Console.WriteLine("No of Nodes: " + circularLinkedList.CountNoOfNodes());
                        break;

                    case 3:
                        Console.WriteLine("Enter the element to be searched: ");
                        //data = Convert.ToInt32(Console.ReadLine());
                        //circularLinkedList.SearchNode(data);
                        break;

                    case 4:
                        Console.Write("Enter the element to be inserted: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        circularLinkedList.InsertAtBeginning(data);
                        break;

                    case 5:
                        Console.Write("Enter the element to be inserted: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        circularLinkedList.InsertAtEnd(data);
                        break;

                    case 6:
                        Console.Write("Enter the element to be inserted: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        circularLinkedList.InsertBefore(data);
                        break;

                    case 7:
                        Console.Write("Enter the element to be inserted: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        circularLinkedList.InsertAfter(data);
                        break;

                    case 8:
                        Console.Write("Enter the element to be inserted: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        circularLinkedList.InsertAtPosition(data);
                        break;

                    case 9:
                        circularLinkedList.DeleteFirst();
                        break;

                    case 10:
                        circularLinkedList.DeleteLast();
                        break;

                    case 11:
                        Console.Write("Enter the element to be deleted: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        circularLinkedList.DeleteNode(data);
                        break;

                    case 12:
                        Console.WriteLine("Enter details of second linked list....");
                        var list2 = new CircularLinkedList<int>();
                        list2.CreateList();
                        circularLinkedList.Concatenate(list2);
                        break;

                    default:
                        Console.WriteLine("Thank you for using my software :)");
                        softwareUsing = false;
                        break;
                }
            }
            */

            #endregion

            #region Header Linked List

            /*
            var softwareUsing = true;

            var headerLinkedList = new HeaderLinkedList<int>();
            headerLinkedList.CreateList();

            while (softwareUsing)
            {
                Console.WriteLine("0. Clear the Console");
                Console.WriteLine("1. Display List");
                Console.WriteLine("2. Count the no of Nodes");
                Console.WriteLine("3. Search for an element");
                Console.WriteLine("4. Insert in beginning of the list");
                Console.WriteLine("5. Insert in end of the list");
                Console.WriteLine("6. Insert before a value");
                Console.WriteLine("7. Insert at a position");
                Console.WriteLine("8. Delete a node with value");
                Console.WriteLine("9. Reverse the list");

                Console.WriteLine("Any other key to  exit");

                Console.WriteLine("Enter your choice");
                var choice = Convert.ToInt32(Console.ReadLine());

                int data;
                //int nodeValue;

                switch (choice)
                {
                    case 0:
                        Console.Clear();
                        break;

                    case 1:
                        headerLinkedList.DisplayList();
                        break;

                    case 2:
                        break;

                    case 3:
                        break;

                    case 4:
                        Console.Write("Enter the value you want to insert: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        headerLinkedList.InsertAtBeginning(data);
                        break;

                    case 5:
                        Console.Write("Enter the value you want to insert: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        headerLinkedList.InsertAtEnd(data);
                        break;

                    case 6:
                        Console.Write("Enter the value you want to insert: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        headerLinkedList.InsertBefore(data);
                        break;

                    case 7:
                        Console.Write("Enter the value you want to insert: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        headerLinkedList.InsertAtPosition(data);
                        break;

                    case 8:
                        Console.Write("Enter the value you want to delete: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        headerLinkedList.DeleteNode(data);
                        break;

                    case 9:
                        headerLinkedList.ReverseList();
                        break;

                    default:
                        Console.WriteLine("\nThank you for using my software :)");
                        softwareUsing = false;
                        break;
                }
            }
            */

            #endregion

            #region Sorted Linked List

            /*             
            var softwareUsing = true;

            var sortedLinkedList = new SortedLinkedList<int>();
            sortedLinkedList.CreateList();

            while (softwareUsing)
            {
                Console.WriteLine("0. Clear the Console");
                Console.WriteLine("1. Display List");
                Console.WriteLine("2. Search for an element");
                Console.WriteLine("3. Insert in the list");
                Console.WriteLine("4. Delete a node");

                Console.WriteLine("Any other key to  exit");

                Console.WriteLine("Enter your choice");
                var choice = Convert.ToInt32(Console.ReadLine());

                int data;

                switch (choice)
                {
                    case 0:
                        Console.Clear();
                        break;

                    case 1:
                        sortedLinkedList.DisplayList();
                        break;

                    case 2:
                        Console.WriteLine("Enter the element to be searched: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        sortedLinkedList.SearchNode(data);
                        break;

                    case 3:
                        Console.Write("Enter the element to be inserted: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        sortedLinkedList.InsertInOrder(data);
                        break;

                    case 4:
                        Console.Write("Enter the element to be deleted: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        sortedLinkedList.DeleteNode(data);
                        break;

                    default:
                        Console.WriteLine("Thank you for using my software :)");
                        softwareUsing = false;
                        break;
                }
            }
            */

            #endregion

            #region Stack using Array

            /*             
            var stackArray = new StackArray<int>(8);

            var softwareUsing = true;

            while (softwareUsing)
            {
                Console.WriteLine("0. Clear the console");
                Console.WriteLine("1. Push an element on the stack");
                Console.WriteLine("2. Pop an element from the stack");
                Console.WriteLine("3. Display the top element");
                Console.WriteLine("4. Display all stack elements");
                Console.WriteLine("5. Display the size of the stack");

                Console.WriteLine("Any other key to exit");

                Console.WriteLine("Enter your choice");

                var choice = Convert.ToInt32(Console.ReadLine());
                int data;

                switch (choice)
                {
                    case 0:
                        Console.Clear();
                        break;

                    case 1:
                        Console.Write("Enter element to push onto stack: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        stackArray.Push(data);
                        break;

                    case 2:
                        data = stackArray.Pop();
                        Console.WriteLine("Popped Element is: " + data);
                        break;

                    case 3:
                        data = stackArray.Peek();
                        Console.WriteLine("Top element is: " + data);
                        break;

                    case 4:
                        stackArray.Display();
                        break;

                    case 5:
                        Console.WriteLine($"Size of the stack is: {stackArray.Size()}");
                        break;

                    default:
                        Console.WriteLine("Thank you for using my software :)");
                        softwareUsing = false;
                        break;
                }
            }
            */

            #endregion

            #region Stack using Linked List

            /*
            var stackLinkedList = new StackLinkedList<int>();

            var softwareUsing = true;

            while (softwareUsing)
            {
                Console.WriteLine("0. Clear the console");
                Console.WriteLine("1. Push an element on the stack");
                Console.WriteLine("2. Pop an element from the stack");
                Console.WriteLine("3. Display the top element");
                Console.WriteLine("4. Display all stack elements");
                Console.WriteLine("5. Display the size of the stack");

                Console.WriteLine("Any other key to exit");

                Console.WriteLine("Enter your choice");

                var choice = Convert.ToInt32(Console.ReadLine());
                int data;

                switch (choice)
                {
                    case 0:
                        Console.Clear();
                        break;

                    case 1:
                        Console.Write("Enter element to push onto stack: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        stackLinkedList.Push(data);
                        break;

                    case 2:
                        data = stackLinkedList.Pop();
                        Console.WriteLine("Popped Element is: " + data);
                        break;

                    case 3:
                        data = stackLinkedList.Peek();
                        Console.WriteLine("Top element is: " + data);
                        break;

                    case 4:
                        stackLinkedList.Display();
                        break;

                    case 5:
                        Console.WriteLine($"Size of the stack is: {stackLinkedList.Size()}\n");
                        break;

                    default:
                        Console.WriteLine("Thank you for using my software :)");
                        softwareUsing = false;
                        break;
                }
            }
            */

            #endregion

            #region Queue using Array

            /*                          
            var queueArray = new QueueArray<int>(8);

            var softwareUsing = true;

            while (softwareUsing)
            {
                Console.WriteLine("0. Clear the console");
                Console.WriteLine("1. Enqueue element");
                Console.WriteLine("2. Dequeue element");
                Console.WriteLine("3. Display the front element");
                Console.WriteLine("4. Display the rear element");
                Console.WriteLine("5. Display the size of the stack");
                Console.WriteLine("6. Display all the elements");

                Console.WriteLine("Any other key to exit");

                Console.WriteLine("Enter your choice");

                var choice = Convert.ToInt32(Console.ReadLine());
                int data;

                switch (choice)
                {
                    case 0:
                        Console.Clear();
                        break;

                    case 1:
                        Console.Write("Enter element to enqueue: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        queueArray.Enqueue(data);
                        break;

                    case 2:
                        data = queueArray.Dequeue();
                        Console.WriteLine("Dequeued Element is: " + data);
                        Console.ReadLine();
                        break;

                    case 3:
                        data = queueArray.FrontElement();
                        Console.WriteLine("Front element is: " + data);
                        Console.ReadLine();
                        break;

                    case 4:
                        data = queueArray.RearElement();
                        Console.WriteLine("Rear element is: " + data);
                        Console.ReadLine();
                        break;

                    case 5:
                        Console.WriteLine($"Size of the stack is: {queueArray.Size()}");
                        Console.ReadLine();
                        break;

                    case 6:
                        queueArray.Display();
                        Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine("Thank you for using my software :)");
                        softwareUsing = false;
                        break;
                }
            }
            */

            #endregion

            #region Queue using Linked List

            /*             
            var queueLinkedList = new QueueLinkedList<int>();

            var softwareUsing = true;

            while (softwareUsing)
            {
                Console.WriteLine("0. Clear the console");
                Console.WriteLine("1. Enqueue element");
                Console.WriteLine("2. Dequeue element");
                Console.WriteLine("3. Display the front element");
                Console.WriteLine("4. Display the rear element");
                Console.WriteLine("5. Display the size of the stack");
                Console.WriteLine("6. Display all the elements");

                Console.WriteLine("Any other key to exit");

                Console.WriteLine("Enter your choice");

                var choice = Convert.ToInt32(Console.ReadLine());
                int data;

                switch (choice)
                {
                    case 0:
                        Console.Clear();
                        break;

                    case 1:
                        Console.Write("Enter element to enqueue: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        queueLinkedList.Enqueue(data);
                        break;

                    case 2:
                        data = queueLinkedList.Dequeue();
                        Console.WriteLine("Dequeued Element is: " + data);
                        Console.ReadLine();
                        break;

                    case 3:
                        data = queueLinkedList.FrontElement();
                        Console.WriteLine("Front element is: " + data);
                        Console.ReadLine();
                        break;

                    case 4:
                        data = queueLinkedList.RearElement();
                        Console.WriteLine("Rear element is: " + data);
                        Console.ReadLine();
                        break;

                    case 5:
                        Console.WriteLine($"Size of the stack is: {queueLinkedList.Size()}");
                        Console.ReadLine();
                        break;

                    case 6:
                        queueLinkedList.Display();
                        Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine("Thank you for using my software :)");
                        softwareUsing = false;
                        break;
                }
            }
            */

            #endregion

            #region Queue using Linked List

            /*             
            var queueCircularLinkedList = new QueueCircularLinkedList<int>();

            var softwareUsing = true;

            while (softwareUsing)
            {
                Console.WriteLine("0. Clear the console");
                Console.WriteLine("1. Enqueue element");
                Console.WriteLine("2. Dequeue element");
                Console.WriteLine("3. Display the front element");
                Console.WriteLine("4. Display the rear element");
                Console.WriteLine("5. Display the size of the stack");
                Console.WriteLine("6. Display all the elements");

                Console.WriteLine("Any other key to exit");

                Console.WriteLine("Enter your choice");

                var choice = Convert.ToInt32(Console.ReadLine());
                int data;

                switch (choice)
                {
                    case 0:
                        Console.Clear();
                        break;

                    case 1:
                        Console.Write("Enter element to enqueue: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        queueCircularLinkedList.Enqueue(data);
                        break;

                    case 2:
                        data = queueCircularLinkedList.Dequeue();
                        Console.WriteLine("Dequeued Element is: " + data);
                        Console.ReadLine();
                        break;

                    case 3:
                        data = queueCircularLinkedList.FrontElement();
                        Console.WriteLine("Front element is: " + data);
                        Console.ReadLine();
                        break;

                    case 4:
                        data = queueCircularLinkedList.RearElement();
                        Console.WriteLine("Rear element is: " + data);
                        Console.ReadLine();
                        break;

                    case 5:
                        Console.WriteLine($"Size of the stack is: {queueCircularLinkedList.Size()}");
                        Console.ReadLine();
                        break;

                    case 6:
                        queueCircularLinkedList.Display();
                        Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine("Thank you for using my software :)");
                        softwareUsing = false;
                        break;
                }
            }
            */

            #endregion

            #region Circular Queue using Array(only)

            /*
            var circularQueue = new CircularQueue<int>(10);

            var softwareUsing = true;

            while (softwareUsing)
            {
                Console.WriteLine("0. Clear the console");
                Console.WriteLine("1. Enqueue element");
                Console.WriteLine("2. Dequeue element");
                Console.WriteLine("3. Display the front element");
                Console.WriteLine("4. Display the rear element");
                Console.WriteLine("5. Display the size of the stack");
                Console.WriteLine("6. Display all the elements");

                Console.WriteLine("Any other key to exit");

                Console.WriteLine("Enter your choice");

                var choice = Convert.ToInt32(Console.ReadLine());
                int data;

                switch (choice)
                {
                    case 0:
                        Console.Clear();
                        break;

                    case 1:
                        Console.Write("Enter element to enqueue: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        circularQueue.Enqueue(data);
                        break;

                    case 2:
                        data = circularQueue.Dequeue();
                        Console.WriteLine("Dequeued Element is: " + data);
                        Console.ReadLine();
                        break;

                    case 3:
                        data = circularQueue.FrontElement();
                        Console.WriteLine("Front element is: " + data);
                        Console.ReadLine();
                        break;

                    case 4:
                        data = circularQueue.RearElement();
                        Console.WriteLine("Rear element is: " + data);
                        Console.ReadLine();
                        break;

                    case 5:
                        Console.WriteLine($"Size of the stack is: {circularQueue.Size()}");
                        Console.ReadLine();
                        break;

                    case 6:
                        circularQueue.Display();
                        Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine("Thank you for using my software :)");
                        softwareUsing = false;
                        break;
                }
            }
            */

            #endregion

            #region Deque using Array
            /*

                        var dequeArray = new DequeArray<int>(10);

                        var softwareUsing = true;

                        while (softwareUsing)
                        {
                            Console.WriteLine("0. Clear the console");
                            Console.WriteLine("1. Enqueue element at front end");
                            Console.WriteLine("2. Enqueue element at rear end");
                            Console.WriteLine("3. Dequeue element at front end");
                            Console.WriteLine("4. Dequeue element at rear end");
                            Console.WriteLine("5. Display the front element");
                            Console.WriteLine("6. Display the rear element");
                            Console.WriteLine("7. Display the size of the queue");
                            Console.WriteLine("8. Display all the elements");

                            Console.WriteLine("Any other key to exit");

                            Console.WriteLine("Enter your choice");

                            var choice = Convert.ToInt32(Console.ReadLine());
                            int data;

                            switch (choice)
                            {
                                case 0:
                                    Console.Clear();
                                    break;

                                case 1:
                                    Console.Write("Enter element to enqueue: ");
                                    data = Convert.ToInt32(Console.ReadLine());
                                    dequeArray.EnqueueFront(data);
                                    break;

                                case 2:
                                    Console.Write("Enter element to enqueue: ");
                                    data = Convert.ToInt32(Console.ReadLine());
                                    dequeArray.EnqueueRear(data);
                                    break;

                                case 3:
                                    data = dequeArray.DequeueFront();
                                    Console.WriteLine("Dequeued element is: " + data);
                                    Console.ReadLine();
                                    break;

                                case 4:
                                    data = dequeArray.DequeueRear();
                                    Console.WriteLine("Dequeued element is: " + data);
                                    Console.ReadLine();
                                    break;

                                case 5:
                                    Console.WriteLine("Front element is: " + dequeArray.FrontElement());
                                    Console.ReadLine();
                                    break;

                                case 6:
                                    Console.WriteLine("Rear element is: " + dequeArray.RearElement());
                                    Console.ReadLine();
                                    break;

                                case 7:
                                    Console.WriteLine($"Size of the queue is {dequeArray.Size()}");
                                    Console.ReadLine();
                                    break;

                                case 8:
                                    dequeArray.Display();
                                    break;

                                default:
                                    Console.WriteLine("Thank you for using my software :)");
                                    softwareUsing = false;
                                    break;
                            }
                        }
            */


            #endregion

            #region Priority Queue using Single Linked List

            /*var priorityQueue = new PriorityQueueLinkedList<int>();

            var softwareUsing = true;

            while (softwareUsing)
            {
                Console.WriteLine("0. Clear the Console");
                Console.WriteLine("1. Enqueue element");
                Console.WriteLine("2. Dequeue element");
                Console.WriteLine("3. Size of the Queue");
                Console.WriteLine("4. Display all elements of the Queue");

                Console.WriteLine("Any other key to exit");

                Console.WriteLine("Enter your choice");

                var choice = Convert.ToInt32(Console.ReadLine());
                int data, priority;

                switch (choice)
                {
                    case 0:
                        Console.Clear();
                        break;

                    case 1:
                        Console.Write("Enter element and its priority to enqueue: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        priority = Convert.ToInt32(Console.ReadLine());
                        priorityQueue.Enqueue(priority, data);
                        break;

                    case 2:
                        data = priorityQueue.Dequeue();
                        Console.WriteLine("Dequeued Element is: " + data);
                        break;

                    case 3:
                        Console.WriteLine($"Size of the queue is {priorityQueue.Size()}");
                        break;

                    case 4:
                        priorityQueue.Display();
                        break;

                    default:
                        Console.WriteLine("Thank you for using my software :)");
                        softwareUsing = false;
                        break;
                }

            }*/

            #endregion

            #region Checking validity of an expression containing nested parentheses
            /*

                        Console.Write("Enter an expression with nested parentheses: ");
                        var expression = Console.ReadLine();

                        Console.WriteLine(IsValid(expression) ? "Valid Expression" : "Invalid Expression");
            */

            #endregion

            #region Infix to Postfix Expression
            /*

            Console.Write("Enter Infix Expression: ");
            var infixExpression = Console.ReadLine();

            var postfixExpression = InfixToPostfix(infixExpression);

            Console.WriteLine("Postfix expression is: " + postfixExpression);
            */

            #endregion

            #region Evaluate Postfix Expression

            //Console.WriteLine("Value of the postfix expression is: " + EvaluatePostfix(postfixExpression));

            #endregion

            #region Practice

            //var n = Convert.ToInt64(Console.ReadLine());
            //Console.WriteLine($"Sum of Digits of {n} is {SumOfDigits(n)}");

            /*
            Console.Write("Enter a positive decimal number: ");
            var n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Binary Form: ");
            ConvertBase(n, 2);
            Console.WriteLine();

            Console.Write("Octal Form: ");
            ConvertBase(n, 8);
            Console.WriteLine();

            Console.Write("Hexadecimal Form: ");
            ConvertBase(n, 16);
            Console.WriteLine();
            */

            //Hanoi(3, 'A', 'B', 'C');

            #endregion

            #region Binary Search Tree

            /*
            var softwareUsing = true;

            var binarySearchTree = new BinarySearchTree<int>();

            while (softwareUsing)
            {
                Console.WriteLine("0. Clear the console");
                Console.WriteLine("1. Display Tree");
                Console.WriteLine("2. Search");
                Console.WriteLine("3. Insert a new node");
                Console.WriteLine("4. Delete a node");
                Console.WriteLine("5. Pre-order traversal");
                Console.WriteLine("6. In-order traversal");
                Console.WriteLine("7. Post-order traversal");
                Console.WriteLine("8. Height of tree");
                Console.WriteLine("9. Find Minimum key");
                Console.WriteLine("10. Find Maximum key");

                Console.WriteLine("Any other key to exit...");

                Console.WriteLine("Enter your choice");
                var choice = Convert.ToInt32(Console.ReadLine());
                var data = 0;

                switch (choice)
                {
                    case 0:
                        Console.Clear();
                        break;

                    case 1:
                        binarySearchTree.Display();
                        break;

                    case 2:
                        Console.Write("Enter element to be searched: ");
                        data = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(binarySearchTree.SearchRecursive(data)
                            ? $"{data} found in the tree"
                            : $"{data} not found in the tree");

                        break;

                    case 3:
                        Console.Write("Enter element to be inserted: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        binarySearchTree.InsertIterative(data);
                        break;

                    case 4:
                        Console.Write("Enter element to be deleted: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        binarySearchTree.DeleteRecursive(data);
                        break;

                    case 5:
                        binarySearchTree.PreOrderTraversal();
                        Console.ReadLine();
                        break;

                    case 6:
                        binarySearchTree.InOrderTraversal();
                        Console.ReadLine();
                        break;

                    case 7:
                        binarySearchTree.PostOrderTraversal();
                        Console.ReadLine();
                        break;

                    case 8:
                        Console.WriteLine($"Height of the tree is {binarySearchTree.Height()}");
                        Console.ReadLine();
                        break;

                    case 9:
                        Console.WriteLine($"Minimum key of the tree is {binarySearchTree.MinRecursive()}");
                        Console.ReadLine();
                        break;

                    case 10:
                        Console.WriteLine($"Minimum key of the tree is {binarySearchTree.MinRecursive()}");
                        Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine("Thank you for using my software :)");
                        softwareUsing = false;
                        break;
                }
            }
            */

            #endregion

            #region Heap

            /*var heapArray = new HeapArray<int>(15);

            var softwareUsing = true;

            while (softwareUsing)
            {
                Console.WriteLine("0. Clear the console");
                Console.WriteLine("1. Display the heap");
                Console.WriteLine("2. Insert value");
                Console.WriteLine("3. Delete value");
                Console.WriteLine("4. Heapify an array and display it");

                Console.WriteLine("Any other key to exit");
                Console.WriteLine("Enter your choice");

                var choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 0:
                        Console.Clear();
                        break;

                    case 1:
                        heapArray.Display();
                        Console.ReadLine();
                        break;

                    case 2:
                        Console.WriteLine("Enter the value you want to insert: ");
                        var data = Convert.ToInt32(Console.ReadLine());
                        heapArray.Insert(data);
                        break;

                    case 3:
                        Console.WriteLine("Deleted root value: " + heapArray.DeleteRoot());
                        Console.ReadLine();
                        break;

                    case 4:
                        Console.WriteLine("Sorry, this feature is not working");
                        break;
                    /*var array = new int[10];
                    foreach (var i in array)
                        array[i] = Convert.ToInt32(Console.ReadLine());

                    heapArray.BulidHeapBottomUp(array, array.Length);
                    heapArray.Display();
                    Console.ReadLine();
                    break;#1#

                    default:
                        Console.WriteLine("Thank you for using my software :)");
                        softwareUsing = false;
                        break;
                }
            }*/

            #endregion
        }

        public static bool IsValid(string expression)
        {
            var stack = new StackArray<char>(10);

            foreach (var exp in expression)
            {
                switch (exp)
                {
                    case '(':
                    case '{':
                    case '[':
                        stack.Push(exp);
                        break;

                    case ')':
                    case '}':
                    case ']':
                        if (stack.IsEmpty())
                        {
                            Console.WriteLine("Right parentheses are more than left parentheses");
                            return false;
                        }
                        else
                        {
                            var parentheses = stack.Pop();

                            if (!MatchedParentheses(parentheses, exp))
                            {
                                Console.WriteLine($"Mismatched parentheses are \'{parentheses}\' and \'{exp}\'");
                                return false;
                            }
                        }

                        break;

                    default:
                        break;
                }
            }

            if (stack.IsEmpty())
            {
                Console.WriteLine("Balanced Parentheses");
                return true;
            }

            Console.WriteLine("Left parentheses are more than right parentheses");
            return false;
        }

        public static bool MatchedParentheses(char leftParentheses, char rightParentheses)
        {
            switch (leftParentheses)
            {
                case '[' when rightParentheses == ']':
                case '{' when rightParentheses == '}':
                case '(' when rightParentheses == ')':
                    return true;

                default:
                    break;
            }

            return false;
        }

        public static string InfixToPostfix(string infixExpression)
        {
            var postfix = "";
            var stack = new StackArray<char>(20);

            foreach (var symbol in infixExpression)
            {
                // Ignore blanks and spaces
                if (symbol == ' ' || symbol == '\t')
                    continue;

                switch (symbol)
                {
                    case '(':
                        stack.Push(symbol);
                        break;

                    case ')':
                        char next;
                        while ((next = stack.Pop()) != '(')
                            postfix += next + " ";

                        break;

                    case '+':
                    case '-':
                    case '*':
                    case '/':
                    case '%':
                    case '^':
                        while (!stack.IsEmpty() && Precedence(stack.Peek()) >= Precedence(symbol))
                            postfix += stack.Pop() + " ";

                        stack.Push(symbol);
                        break;

                    // Operand
                    default:
                        postfix += symbol + " ";
                        break;
                }
            }

            while (!stack.IsEmpty())
                postfix += stack.Pop();

            postfix += " ";

            return postfix;
        }

        public static int Precedence(char symbol)
        {
            switch (symbol)
            {
                case '(':
                    return 0;

                case '+':
                case '-':
                    return 1;

                case '*':
                case '/':
                case '%':
                    return 2;

                case '^':
                    return 3;

                default:
                    return 0;
            }
        }

        public static int EvaluatePostfix(string postfixExpression)
        {
            var stack = new StackArray<int>(20);

            foreach (var postfix in postfixExpression)
            {
                if (postfix == ' ' || postfix == '\t')
                    continue;

                if (char.IsDigit(postfix))
                    stack.Push(Convert.ToInt32(char.GetNumericValue(postfix)));

                else
                {
                    var x = stack.Pop();
                    var y = stack.Pop();

                    switch (postfix)
                    {
                        case '+':
                            stack.Push(y + x);
                            break;

                        case '-':
                            stack.Push(y - x);
                            break;

                        case '*':
                            stack.Push(y * x);
                            break;

                        case '/':
                            stack.Push(y / x);
                            break;

                        case '%':
                            stack.Push(y % x);
                            break;

                        case '^':
                            stack.Push(Power(y, x));
                            break;

                        default:
                            break;
                    }
                }
            }

            return stack.Pop();
        }

        public static int Power(int coefficient, int exponent)
        {
            if (exponent < 0 || coefficient < 0)
                throw new InvalidOperationException("Cannot power with negetive exponent or coefficient!");

            if (exponent == 0)
                return 1;

            return coefficient * Power(coefficient, exponent - 1);
        }

        public static long Factorial(long n)
        {
            if (n == 0)
                return 1;

            return n * Factorial(n - 1);
        }

        public static long SumOfDigits(long n)
        {
            if (n / 10 == 0)
                return n;

            return SumOfDigits(n / 10) + n % 10;
        }

        public static void ConvertBase(int number, int baseValue)
        {
            if (number == 0)
                return;

            ConvertBase(number / baseValue, baseValue);

            var remainder = number % baseValue;

            if (remainder < 10)
                Console.Write(remainder);
            else
                Console.Write((char)(remainder - 10 + 'A'));
        }

        public static long GreatestCommonDivisor(long a, long b) => b == 0 ? a : GreatestCommonDivisor(b, a % b);

        public static void Hanoi(int numberOfDisks, char source, char temp, char destination)
        {
            if (numberOfDisks == 1)
            {
                Console.WriteLine($"Move disk {numberOfDisks} from {source} to {destination}");
                return;
            }

            Hanoi(numberOfDisks - 1, source, destination, temp);

            Console.WriteLine($"Move disk {numberOfDisks} from {source} to {destination}");

            Hanoi(numberOfDisks - 1, temp, source, destination);
        }
    }
}
