using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Queue<T> : IDataStructures<T>
    {
        private CustomNode<T> _head;
        private int _count = 0;
        private int _max = -1;

        public int Count { get => Count1; set => Count1 = value; }
        public int Max { get => _max; set => _max = value; }
        public int Count1 { get => _count; set => _count = value; }

        public Queue()
        {
            _head = null;
            Max = -1;
        }

        public Queue(int maxValue)
        {
            Max = maxValue;
        }

        public void Add(ref T value)
        {
            if (Count == Max)
                return;
            CustomNode<T> newNode = new CustomNode<T>(ref value);
            if (_head == null)
            {
                _head = newNode;
                newNode.Next = _head;
                newNode.Prev = _head;
                newNode.Index = 0;
                Count1++;
                return;
            }
            if (_head.Next == _head)
            {
                _head.Next = newNode;
                newNode.Index = 1;
                newNode.Next = _head;
                newNode.Prev = _head;
                _head.Prev = newNode;
                Count1++;
                return;
            }
            newNode.Next = _head;
            newNode.Prev = _head.Prev;
            newNode.Index = _head.Prev.Index + 1;
            _head.Prev = newNode;
            newNode.Prev.Next = newNode;
            Count1++;
        }

        public void Display()
        {
            if (_head == null)
                return;
            Console.WriteLine(_head.Data);
            for (CustomNode<T> iterator = _head.Next; iterator != _head; iterator = iterator.Next)
            {
                Console.WriteLine(iterator.Data);
            }
        }

        public void Remove(ref T value)
        {
            if (_head == null)
                return;
            if (System.Collections.Generic.EqualityComparer<T>.Default.Equals(_head.Data, value))
            {
                if (_head.Next == _head)
                {
                    Count--;
                    _head = null;
                    return;
                }
                for (CustomNode<T> index = _head.Next; index != _head; index = index.Next)
                {
                    index.Index--;
                }
                _head.Next.Prev = _head.Prev;
                _head.Prev.Next = _head.Next;
                _head = _head.Next;
                Count1--;
                return;
            }
            CustomNode<T> iterator = _head.Next;
            for (; iterator != _head; iterator = iterator.Next)
            {
                if (System.Collections.Generic.EqualityComparer<T>.Default.Equals(iterator.Data, value))
                {
                    iterator.Prev.Next = iterator.Next;
                    iterator.Next.Prev = iterator.Prev;
                    for (CustomNode<T> index = iterator.Next; index != _head; index = index.Next)
                    {
                        index.Index--;
                    }
                    Count1--;
                    return;
                }
            }
        }

        public void Sort()
        {
            if (_head == null || _head.Next == _head)
                return;
            T tempData;
            int tempIndex;
            CustomNode<T> iterator1 = _head.Next;
            CustomNode<T> iterator2 = _head.Next;
            for (; iterator1 != _head; iterator1 = iterator1.Next)
            {
                for (; iterator2 != _head; iterator2 = iterator2.Next)
                {
                    if (Convert.ToInt32(iterator2.Data) > Convert.ToInt32(iterator2.Next.Data))
                    {
                        tempData = iterator2.Data;
                        tempIndex = iterator2.Index;
                        iterator2.Data = iterator2.Next.Data;
                        iterator2.Index = iterator2.Next.Index;
                        iterator2.Next.Data = tempData;
                        iterator2.Next.Index = tempIndex;

                    }
                }
            }

        }

        public void Enqueue(ref T value)
        {
            Add(ref value);
        }

        public void Dequeue()
        {
            if (_head == null)
                return;
            if (_head.Next == _head)
            {
                _head = null;
                return;
            }
            _head.Next.Prev = _head.Prev;
            _head.Prev.Next = _head.Next;
            _head = _head.Next;
            Count--;
        }

        public T Peek()
        {
            if (_head == null)
                return default(T);
            return _head.Data;
        }
        public bool IsEmpty()
        {
            if (_head == null)
                return true;
            return false;
        }
        public bool IsFull()
        {
            if (Count == Max)
                return true;
            return false;
        }
    }
}
