using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class CustomNode<T>
    {
        private T _data;
        private CustomNode<T> next;
        private CustomNode<T> prev;
        private int _index;
        public CustomNode(ref T value)
        {
            Data = value;
        }

        public T Data { get => _data; set => _data = value; }
        public int Index { get => _index; set => _index = value; }
        internal CustomNode<T> Next { get => next; set => next = value; }
        internal CustomNode<T> Prev { get => prev; set => prev = value; }
    }
}
