﻿using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class LinkedList<T> : IDataStructures<T>
    {
        private CustomNode<T> _head;
        private int _count = 0;

        public int Count { get => Count1; set => Count1 = value; }
        public int Count1 { get => _count; set => _count = value; }

        public LinkedList()
        {
            _head = null;
        }

        public void Add(ref T value)
        {
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

        public void AddAt(ref T value, int index)
        {
            if (index > Count1)
                return;
            CustomNode<T> newNode = new CustomNode<T>(ref value);
            newNode.Index = index;
            newNode.Index = index;
            if (index == 0)
            {
                if (Count == 0)
                {
                    _head = newNode;
                    newNode.Next = _head;
                    newNode.Prev = _head;
                    Count++;
                    return;
                }
                newNode.Next = _head;
                newNode.Prev = _head.Prev;
                _head.Prev.Next = newNode;
                _head.Prev = newNode;
                _head = newNode;
                Count++;
                for (CustomNode<T> iterator = _head.Next; iterator != _head; iterator = iterator.Next)
                {
                    iterator.Index++;
                }
                return;
            }
            if (index == Count)
            {
                newNode.Prev = _head.Prev;
                newNode.Next = _head;
                _head.Prev.Next = newNode;
                _head.Prev = newNode;
                return;
            }
            CustomNode<T> iterator1 = _head.Next;
            for (; iterator1 != _head; iterator1 = iterator1.Next)
            {
                if (iterator1.Index == index)
                {
                    newNode.Prev = iterator1.Prev;
                    newNode.Next = iterator1;
                    iterator1.Prev.Next = newNode;
                    iterator1.Prev = newNode;
                    for (CustomNode<T> iterator2 = newNode.Next; iterator2 != _head; iterator2 = iterator2.Next)
                        iterator2.Index++;
                }
            }
        }

        public void RemoveAt(int index)
        {
            if (index >= Count1)
                return;
            Count--;
            if (index == 0)
            {
                if (_head.Next == _head)
                {
                    _head = null;
                    return;
                }
                _head.Next.Prev = _head.Prev;
                _head.Prev.Next = _head.Next;
                _head = _head.Next;
                _head.Index = 0;
                for (CustomNode<T> iterator = _head.Next; iterator != _head; iterator = iterator.Next)
                {
                    iterator.Index--;
                }
                return;
            }
            for (CustomNode<T> iterator = _head.Next; iterator != _head; iterator = iterator.Next)
            {
                if (iterator.Index == index)
                {
                    iterator.Prev.Next = iterator.Next;
                    iterator.Next.Prev = iterator.Prev;
                    if (iterator.Next == _head)
                        return;
                    for (CustomNode<T> iterator2 = iterator.Next; iterator2 != _head; iterator2 = iterator2.Next)
                        iterator2.Index--;
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
                        tempData =iterator2.Data;
                        tempIndex = iterator2.Index;
                        iterator2.Data = iterator2.Next.Data;
                        iterator2.Index = iterator2.Next.Index;
                        iterator2.Next.Data = tempData;
                        iterator2.Next.Index = tempIndex;

                    }
                }
            }

        }

        public void Clear()
        {
            _head = null;
        }
    }
}
