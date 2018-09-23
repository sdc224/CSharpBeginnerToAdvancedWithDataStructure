using System;

namespace DataStructuresAndAlgorithms.DataStructures.StackAndQueue.Queue
{
    public class DequeArray<TData>
    {
        public TData[] DequeElements;
        private int _front;
        private int _rear;

        public DequeArray()
        {
            DequeElements = new TData[10];
            _front = _rear = -1;
        }

        public DequeArray(int maxSize)
        {
            DequeElements = new TData[maxSize];
            _front = _rear = -1;
        }

        private bool IsEmpty() => _front == -1;

        private bool IsFull() => _front == _rear + 1 || _front == 0 && _rear == DequeElements.Length - 1;

        public void EnqueueFront(TData data)
        {
            if (IsFull())
            {
                Console.WriteLine("Queue overflow!");
                return;
            }

            if (_front == -1)
                _front = _rear = 0;

            else if (_front == 0)
                _front = DequeElements.Length - 1;

            else
                _front--;

            DequeElements[_front] = data;
        }

        public void EnqueueRear(TData data)
        {
            if (IsFull())
            {
                Console.WriteLine("Queue overflow!");
                return;
            }

            if (_front == -1)
                _front = 0;

            if (_rear == DequeElements.Length - 1)
                _rear = 0;
            else
                _rear++;

            DequeElements[_rear] = data;
        }

        public TData DequeueFront()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Queue underflow!");

            var dequeuedElement = DequeElements[_front];

            if (_front == _rear)
                _front = _rear = -1;

            else if (_front == DequeElements.Length - 1)
                _front = 0;
            else
                _front++;

            return dequeuedElement;
        }

        public TData DequeueRear()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Queue underflow!");

            var dequeuedElement = DequeElements[_rear];

            if (_front == _rear)
                _front = _rear = -1;

            else if (_rear == 0)
                _rear = DequeElements.Length - 1;

            else
                _rear--;

            return dequeuedElement;
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
                    Console.Write(DequeElements[index++] + " ");
            }

            else
            {
                while (index <= DequeElements.Length - 1)
                    Console.Write(DequeElements[index++] + " ");

                index = 0;

                while (index <= _rear)
                    Console.Write(DequeElements[index++] + " ");
            }

            Console.WriteLine();
        }

        public TData FrontElement()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Queue underflow!");

            return DequeElements[_front];
        }

        public TData RearElement()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Queue underflow!");

            return DequeElements[_rear];
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
                while (index <= DequeElements.Length - 1)
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
