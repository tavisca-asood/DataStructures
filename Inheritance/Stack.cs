using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Stack<T>:IDataStructures<T>
    {
        private static int _count = 1;
        CustomNode<T> top = null;

        internal CustomNode<T> Top { get => top; set => top = value; }

        public void Add(ref T value)
        {
            CustomNode<T> newNode = new CustomNode<T>(ref value);
            newNode.Index = _count++;
            if (top == null)
            {
                top = newNode;
                return;
            }
            CustomNode<T> iterator = top;
            for (; iterator.Next != null; iterator = iterator.Next) { }
            iterator.Next = newNode;
        }

        public void Display()
        {
            for (CustomNode<T> iterator = top; iterator != null; iterator = iterator.Next)
            {
                Console.WriteLine(iterator.Data);
            }
        }

        public void Remove(ref T value)
        {
            if (top.Next == null)
            {
                top = null;
                _count--;
                return;
            }
            CustomNode<T> iterator = top;
            for (; iterator.Next != null; iterator = iterator.Next) { }
        }

        public void Sort()
        {
            throw new NotImplementedException();
        }
        public void Push(ref T value)
        {
            if (top.Next == null)
            {
                top = null;
                _count--;
                return;
            }
            CustomNode<T> iterator = top;
            for (; iterator.Next != null; iterator = iterator.Next) { }
        }
    }
}
