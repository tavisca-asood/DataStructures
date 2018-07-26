using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class LinkedList<T> : IDataStructures<T>
    {
        private static int _index = -1;
        private CustomNode<T> _head;

        public LinkedList()
        {
            _head = null;
        }

        public void Add(ref T value)
        {
            CustomNode<T> newNode = new CustomNode<T>(ref value);
            newNode.Index = _index++;
            if (_head == null)
            {
                _head = newNode;
                newNode.Next = _head;
                _head.Prev = newNode;
                return;
            }
            newNode.Next = _head;
            _head.Prev = newNode;
            CustomNode<T> iterator = _head;
            for (; iterator.Next != _head; iterator = iterator.Next) { }
            iterator.Next = newNode;
            newNode.Prev = iterator;
        }

        public void Display()
        {
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
            if (EqualityComparer<T>.Default.Equals(_head.Data, value))
            {
                if(_head.Next==_head)
                {
                    _head = null;
                    return;
                }
                _head.Next.Prev = _head.Prev;
                _head.Prev.Next = _head.Next;
                _head = _head.Next;
            }
            CustomNode<T> iterator = _head;
            for (; iterator.Next != null; iterator = iterator.Next)
            {
                if (EqualityComparer<T>.Default.Equals(iterator.Data, value))
                {
                    iterator.Prev.Next = iterator.Next;
                    iterator.Next.Prev = iterator.Prev;
                    return;
                }
            }
        }

        public void Sort()
        {
            throw new NotImplementedException();
        }
    }
}
