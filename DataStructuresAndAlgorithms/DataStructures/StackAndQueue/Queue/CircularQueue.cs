using System;

namespace DataStructuresAndAlgorithms.DataStructures.StackAndQueue.Queue
{
    public class CircularQueue<TData>
    {
        public TData[] QueueData;
        private int _front;
        private int _rear;

        public CircularQueue()
        {
            QueueData = new TData[10];
            _front = _rear = -1;
        }

        public CircularQueue(int maxSize)
        {
            QueueData = new TData[maxSize];
            _front = _rear = -1;
        }

        private bool IsEmpty() => _front == -1;

        private bool IsFull() => _front == _rear + 1 || _front == 0 && _rear == QueueData.Length - 1;

        public void Enqueue(TData data)
        {
            if (IsFull())
            {
                Console.WriteLine("Queue overflow!");
                return;
            }

            if (_front == -1)
                _front = 0;

            if (_rear == QueueData.Length - 1)
                _rear = 0;

            else
                _rear++;

            QueueData[_rear] = data;
        }

        public TData Dequeue()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Queue underflow!");

            var dequeuedElement = QueueData[_front];

            // Queue contains one element
            if (_front == _rear)
                _front = _rear = -1;

            else if (_front == QueueData.Length - 1)
                _front = 0;

            else
                _front++;

            return dequeuedElement;
        }

        public TData FrontElement()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Queue underflow!");

            return QueueData[_front];
        }

        public TData RearElement()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Queue underflow!");

            return QueueData[_rear];
        }

        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty!");
                return;
            }

            Console.Write("Queue has: ");

            var index = _front;

            if (_front <= _rear)
            {
                while (index <= _rear)
                    Console.Write(QueueData[index++] + " ");
            }

            else
            {
                while (index <= QueueData.Length - 1)
                    Console.Write(QueueData[index++] + " ");

                index = 0;

                while (index <= _rear)
                    Console.Write(QueueData[index++] + " ");
            }

            Console.WriteLine();
        }

        public int Size()
        {
            if (IsEmpty())
                return 0;

            var index = _front;
            var size = 0;

            if (_front <= _rear)
            {
                while (index <= _rear)
                {
                    index++;
                    size++;
                }
            }

            else
            {
                while (index <= QueueData.Length - 1)
                {
                    index++;
                    size++;
                }

                index = 0;

                while (index <= _rear)
                {
                    index++;
                    size++;
                }
            }

            return size;
        }
    }
}
