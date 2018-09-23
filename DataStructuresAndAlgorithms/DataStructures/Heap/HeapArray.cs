using System;

namespace DataStructuresAndAlgorithms.DataStructures.Heap
{
    public static class TypeExtension
    {
        public static TData MinValue<TData>(this Type self)
        {
            return (TData)self.GetField(nameof(MinValue)).GetRawConstantValue();
        }

        public static TData MaxValue<TData>(this Type self)
        {
            return (TData)self.GetField(nameof(MaxValue)).GetRawConstantValue();
        }
    }

    public class HeapArray<TData> where TData : IComparable
    {
        private readonly TData[] _heapData;
        private int _noOfNodes;

        public HeapArray()
        {
            _heapData = new TData[10];
            _noOfNodes = 0;
            _heapData[0] = typeof(TData).MaxValue<TData>();
        }

        public HeapArray(int maxSize)
        {
            _heapData = new TData[maxSize];
            _noOfNodes = 0;
            _heapData[0] = typeof(TData).MaxValue<TData>();
        }

        public void Insert(TData data)
        {
            _noOfNodes++;
            _heapData[_noOfNodes] = data;
            RestoreUp(_noOfNodes);
        }

        private void RestoreUp(int i)
        {
            var key = _heapData[i];
            var parentOfI = i / 2;

            // No sentinel - while(parentOfI >= 1 && _heapData[parentOfI] < key)
            while (_heapData[parentOfI].CompareTo(key) == -1)
            {
                _heapData[i] = _heapData[parentOfI];
                i = parentOfI;
                parentOfI = i / 2;
            }

            _heapData[i] = key;
        }

        public TData DeleteRoot()
        {
            if (_noOfNodes == 0)
                throw new InvalidOperationException("Heap is Empty!");

            var maxValue = _heapData[1];
            _heapData[1] = _heapData[_noOfNodes];
            _noOfNodes--;
            RestoreDown(1);
            return maxValue;
        }

        private void RestoreDown(int i)
        {
            var key = _heapData[i];
            var leftChild = 2 * i;
            var rightChild = leftChild + 1;

            while (rightChild <= _noOfNodes)
            {
                if (key.CompareTo(_heapData[leftChild]) != -1 && key.CompareTo(_heapData[rightChild]) != -1)
                {
                    _heapData[i] = key;
                    return;
                }

                if (_heapData[leftChild].CompareTo(_heapData[rightChild]) != -1)
                {
                    _heapData[i] = _heapData[leftChild];
                    i = leftChild;
                }

                else
                {
                    _heapData[i] = _heapData[rightChild];
                    i = rightChild;
                }

                leftChild = 2 * i;
                rightChild = leftChild + 1;
            }

            // For even no of nodes (See notes for doubt)
            if (leftChild == _noOfNodes && key.CompareTo(_heapData[leftChild]) == -1)
            {
                _heapData[i] = _heapData[leftChild];
                i = leftChild;
            }

            _heapData[i] = key;
        }

        private void RestoreDown(int i, int size)
        {
            var key = _heapData[i];
            var leftChild = 2 * i;
            var rightChild = leftChild + 1;

            while (rightChild <= size)
            {
                if (key.CompareTo(_heapData[leftChild]) != -1 && key.CompareTo(_heapData[rightChild]) != -1)
                {
                    _heapData[i] = key;
                    return;
                }

                if (_heapData[leftChild].CompareTo(_heapData[rightChild]) != -1)
                {
                    _heapData[i] = _heapData[leftChild];
                    i = leftChild;
                }

                else
                {
                    _heapData[i] = _heapData[rightChild];
                    i = rightChild;
                }

                leftChild = 2 * i;
                rightChild = leftChild + 1;
            }

            // For even no of nodes (See notes for doubt)
            if (leftChild == size && key.CompareTo(_heapData[leftChild]) == -1)
            {
                _heapData[i] = _heapData[leftChild];
                i = leftChild;
            }

            _heapData[i] = key;
        }

        public void BulidHeapTopDown(TData[] array, int size)
        {
            for (var i = 2; i < size; i++)
                RestoreUp(i);
        }

        public void BulidHeapBottomUp(TData[] array, int size)
        {
            for (var i = size / 2; i >= 1; i--)
                RestoreDown(i);
        }

        public void Display()
        {
            if (_noOfNodes == 0)
            {
                Console.WriteLine("Heap is empty");
                Console.WriteLine("Size of the heap is: " + _noOfNodes);
                return;
            }

            Console.Write("Heap has: ");

            for (var i = 1; i < _noOfNodes; i++)
                Console.Write(_heapData[i] + " ");

            Console.WriteLine();

            Console.WriteLine("Size of the heap is: " + _noOfNodes);
        }
    }
}
