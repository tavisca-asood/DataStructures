using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Stack<T> : IDataStructures<T>
    {
        private int _count = 0;
        CustomNode<T> top = null;

        internal CustomNode<T> Top { get => top; set => top = value; }
        public int Count { get => _count; set => _count = value; }

        public void Add(ref T value)
        {
            CustomNode<T> newNode = new CustomNode<T>(ref value);
            newNode.Index = Count++;
            if (top == null)
            {
                top = newNode;
                top.Next = top;
                top.Prev = top;
                return;
            }
            newNode.Next = top;
            newNode.Prev = top.Prev;
            top.Prev.Next = newNode;
            top.Prev = newNode;
            top = newNode;
        }

        public void Display()
        {
            if (top == null)
                return;
            Console.WriteLine(Top.Data);
            for (CustomNode<T> iterator = Top.Next; iterator != Top; iterator = iterator.Next)
            {
                Console.WriteLine(iterator.Data);
            }
        }

        public void Remove(ref T value)
        {
            if (top == null)
                return;
            if (System.Collections.Generic.EqualityComparer<T>.Default.Equals(top.Data, value))
            {
                if (top.Next == top)
                {
                    top = null;
                    return;
                }
                for (CustomNode<T> index = top.Next; index != top; index = index.Next)
                {
                    index.Index--;
                }
                top.Next.Prev = top.Prev;
                top.Prev.Next = top.Next;
                top = top.Next;
                Count--;
                return;
            }
            CustomNode<T> iterator = top.Next;
            for (; iterator != top; iterator = iterator.Next)
            {
                if (System.Collections.Generic.EqualityComparer<T>.Default.Equals(iterator.Data, value))
                {
                    iterator.Prev.Next = iterator.Next;
                    iterator.Next.Prev = iterator.Prev;
                    for (CustomNode<T> index = iterator.Next; index != top; index = index.Next)
                    {
                        index.Index--;
                    }
                    Count--;
                    return;
                }
            }

        }

        public void Sort()
        {
            if (top == null || top.Next == top)
                return;
            T tempData;
            int tempIndex;
            CustomNode<T> iterator1 = top.Next;
            CustomNode<T> iterator2 = top.Next;
            for (; iterator1 != top; iterator1 = iterator1.Next)
            {
                for (; iterator2 != top; iterator2 = iterator2.Next)
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
        public void Push(ref T value)
        {
            Add(ref value);
        }
        public void Pop()
        {
            if (top == null)
                return;
            if (Count == 1)
            {
                top = null;
                Count--;
                return;
            }
            top.Prev.Next = top.Next;
            top.Next.Prev = top.Prev;
            top = top.Next;
            Count--;
        }

        public T GetTop()
        {
            if (top == null)
                return default(T);
            return top.Data;
        }
        public void Clear()
        {
            top = null;
        }
    }
}