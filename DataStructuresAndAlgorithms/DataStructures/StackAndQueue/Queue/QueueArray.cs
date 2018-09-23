using System;

namespace DataStructuresAndAlgorithms.DataStructures.StackAndQueue.Queue
{
    public class QueueArray<TData>
    {
        public TData[] QueueElements;
        private int _front;
        private int _rear;

        public QueueArray()
        {
            QueueElements = new TData[10];
            _front = _rear = -1;
        }

        public QueueArray(int maxSize)
        {
            QueueElements = new TData[maxSize];
            _front = _rear = -1;
        }

        public bool IsEmpty() => _front == -1 || _front == _rear + 1;

        public bool IsFull() => _rear == QueueElements.Length - 1;

        public int Size()
        {
            if (IsEmpty())
                return 0;

            return _rear - _front + 1;
        }

        public void Enqueue(TData data)
        {
            if (IsFull())
            {
                Console.WriteLine("Queue overflow!");
                return;
            }

            if (_front == -1)
                _front = 0;

            QueueElements[++_rear] = data;
        }

        public TData Dequeue()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Queue underflow!");

            return QueueElements[_front++];
        }

        public TData FrontElement()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Queue underflow!");

            return QueueElements[_front];
        }

        public TData RearElement()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Queue underflow!");

            return QueueElements[_rear];
        }

        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is Empty!");
                return;
            }

            Console.Write("Queue is: ");
            for (var i = _front; i <= _rear; i++)
                Console.Write(QueueElements[i] + " ");

            Console.WriteLine();
        }
    }
}
