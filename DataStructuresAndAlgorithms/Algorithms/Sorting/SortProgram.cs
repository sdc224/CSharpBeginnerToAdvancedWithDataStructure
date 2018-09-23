using DataStructuresAndAlgorithms.DataStructures.Heap;
using DataStructuresAndAlgorithms.DataStructures.Tree;
using System;
using System.Collections.Generic;

namespace DataStructuresAndAlgorithms.Algorithms.Sorting
{
    public class SortProgram
    {
        // Function AlgorithmMain
        public static void Main(string[] args)
        {
            var array = new[] { 10, 8, 25, 14, 24, 11 };

            //var sortedItems = SelectionSort(array, array.Length);
            //var sortedItems = BubbleSort(array, array.Length);
            //var sortedItems = InsertionSort(array, array.Length);
            //var sortedItems = ShellSort(array, array.Length, 5);
            //MergeSort(array, array.Length);
            //QuickSort(array, array.Length);
            //BinarySearchTreeSort(array, array.Length);
            //HeapSort(array, array.Length);


            Console.Write("Elements after sorting: ");

            //foreach (var i in sortedItems)
            //    Console.Write(i + " ");

            foreach (var i in array)
                Console.Write(i + " ");

            Console.WriteLine();
        }

        #region Utility Functions

        public static void Swap<T>(ref T data1, ref T data2)
        {
            var temp = data1;
            data1 = data2;
            data2 = temp;
        }

        #endregion

        public static T[] SelectionSort<T>(T[] data, int size) where T : IComparable
        {
            for (var i = 0; i < size - 1; i++)
            {
                var minIndex = i;

                for (var j = i + 1; j < size; j++)
                    if (data[j].CompareTo(data[minIndex]) == -1)
                        minIndex = j;

                if (i != minIndex)
                    Swap(ref data[i], ref data[minIndex]);
            }

            return data;
        }

        public static T[] BubbleSort<T>(T[] data, int size) where T : IComparable
        {
            for (var i = 0; i < size - 1; i++)
            {
                var swapped = false;

                for (var j = 0; j < size - 1; j++)
                {
                    if (data[j].CompareTo(data[j + 1]) == -1)
                        continue;

                    Swap(ref data[j], ref data[j + 1]);
                    swapped = true;
                }

                if (swapped == false)
                    break;
            }

            return data;
        }

        public static T[] InsertionSort<T>(T[] data, int size) where T : IComparable
        {
            for (var i = 1; i < size; i++)
            {
                var key = data[i];
                int j;

                for (j = i - 1; j >= 0 && data[j].CompareTo(key) == 1; j--)
                    data[j + 1] = data[j];

                data[j + 1] = key;
            }

            return data;
        }

        // increment - h
        public static T[] ShellSort<T>(T[] data, int size, int h) where T : IComparable
        {
            while (h >= 1)
            {
                for (var i = h; i < size; i++)
                {
                    var key = data[i];
                    int j;

                    for (j = i - h; j >= 0 && data[j].CompareTo(key) == 1; j = j - h)
                        data[j + h] = data[j];

                    data[j + h] = key;
                }

                h = h - 2;
            }

            return data;
        }

        #region Merge Sort

        public static void MergeSort<T>(T[] data, int size) where T : IComparable
        {
            var tempArray = new T[size];
            //MergeSortRecursive(data, tempArray, 0, size - 1);
            var sizeOfSublist = 1;

            while (sizeOfSublist <= size - 1)
            {
                SortPass(data, tempArray, sizeOfSublist, size);
                sizeOfSublist *= 2;
            }
        }

        private static void SortPass<T>(T[] data, T[] tempArray, int sizeOfSublist, int size) where T : IComparable
        {
            var low1 = 0;

            while (low1 + sizeOfSublist <= size - 1)
            {
                var up1 = low1 + sizeOfSublist - 1;
                var low2 = low1 + sizeOfSublist;
                var up2 = low2 + sizeOfSublist - 1;

                if (up2 >= size)
                    up2 = size - 1;

                Merge(data, tempArray, low1, up1, low2, up2);

                low1 = up2 + 1;
            }

            for (var i = low1; i <= sizeOfSublist - 1; i++)
                tempArray[i] = data[i];

            Copy(data, tempArray, size);
        }

        private static void Copy<T>(IList<T> data, IReadOnlyList<T> tempArray, int size) where T : IComparable
        {
            for (var i = 0; i < size; i++)
                data[i] = tempArray[i];
        }

        private static void MergeSortRecursive<T>(T[] data, T[] tempArray, int start, int end) where T : IComparable
        {
            if (start == end)
                return;

            var mid = (start + end) / 2;

            MergeSortRecursive(data, tempArray, start, mid);
            MergeSortRecursive(data, tempArray, mid + 1, end);

            Merge(data, tempArray, start, mid, mid + 1, end);

            Copy(data, tempArray, start, end);
        }

        private static void Merge<T>(IReadOnlyList<T> data, IList<T> tempArray, int start1, int end1, int start2, int end2)
            where T : IComparable
        {
            var i = start1;
            var j = start2;
            var k = start1;

            while (i <= end1 && j <= end2)
            {
                if (data[i].CompareTo(data[j]) == -1)
                    tempArray[k++] = data[i++];

                else
                    tempArray[k++] = data[j++];
            }

            while (i <= end1)
                tempArray[k++] = data[i++];

            while (j <= end2)
                tempArray[k++] = data[j++];
        }

        private static void Copy<T>(IList<T> data, IReadOnlyList<T> tempArray, int start, int end)
        {
            for (var i = start; i <= end; i++)
                data[i] = tempArray[i];
        }

        #endregion

        #region Quick Sort

        public static void QuickSort<T>(T[] data, int size) where T : IComparable
        {
            QuickSortRecursive(data, 0, size - 1);
        }

        private static void QuickSortRecursive<T>(T[] data, int start, int end) where T : IComparable
        {
            if (start >= end)
                return;

            var pivotPosition = Partition(data, start, end);

            QuickSortRecursive<T>(data, start, pivotPosition - 1);
            QuickSortRecursive<T>(data, pivotPosition + 1, end);
        }

        private static int Partition<T>(T[] data, int start, int end) where T : IComparable
        {
            // Using last element as pivot (www.geeksforgeeks.org)
            /*var pivot = data[end];
            var j = start - 1;

            for (var i = start; i < end; i++)
            {
                if (data[i].CompareTo(pivot) == 1)
                    continue;

                j++;
                Swap(ref data[i], ref data[j]);
            }

            Swap(ref data[j + 1], ref data[end]);

            return j + 1;*/

            // Using last element as pivot (Class method)
            var pivot = data[start];

            // start + 1 as we have considered the start element as pivot
            // i moves from left to right and j moves feom right to left
            var i = start + 1;
            var j = end;

            while (i <= j)
            {
                while (data[i].CompareTo(pivot) == -1 && i < end)
                    i++;

                while (data[j].CompareTo(pivot) == 1)
                    j--;

                // Swap data[i] and data[j]
                if (i < j)
                {
                    Swap(ref data[i], ref data[j]);
                    i++;
                    j--;
                }

                // Proper position for pivot is found
                else
                    break;
            }

            // Proper place for pivot is j
            data[start] = data[j];
            data[j] = pivot;

            return j;
        }

        #endregion

        public static void BinarySearchTreeSort<T>(T[] data, int size) where T : IComparable
        {
            var binarySearchTree = new BinarySearchTree<T>();

            for (var i = 0; i < size; i++)
                binarySearchTree.InsertRecursive(data[i]);

            binarySearchTree.InOrderTraversal();
        }

        #region Heap Sort

        public static void HeapSort<T>(T[] data, int size) where T : IComparable
        {
            var heapArray = new HeapArray<T>(size);
            heapArray.BulidHeapBottomUp(data, size);

            while (size > 1)
            {
                var maxValue = data[1];
                data[1] = data[size];
                data[size] = maxValue;
                size--;
                RestoreDown(1, data, size);
            }
        }

        public void BulidHeapBottomUp<T>(T[] data, int size) where T : IComparable
        {
            for (var i = size / 2; i >= 1; i--)
                RestoreDown(i, data, size);
        }

        private static void RestoreDown<T>(int i, T[] data, int size) where T : IComparable
        {
            var key = data[i];
            var leftChild = 2 * i;
            var rightChild = leftChild + 1;

            while (rightChild <= size)
            {
                if (key.CompareTo(data[leftChild]) != -1 && key.CompareTo(data[rightChild]) != -1)
                {
                    data[i] = key;
                    return;
                }

                if (data[leftChild].CompareTo(data[rightChild]) != -1)
                {
                    data[i] = data[leftChild];
                    i = leftChild;
                }

                else
                {
                    data[i] = data[rightChild];
                    i = rightChild;
                }

                leftChild = 2 * i;
                rightChild = leftChild + 1;
            }

            // For even no of nodes (See notes for doubt)
            if (leftChild == size && key.CompareTo(data[leftChild]) == -1)
            {
                data[i] = data[leftChild];
                i = leftChild;
            }

            data[i] = key;
        }

        #endregion


    }
}
