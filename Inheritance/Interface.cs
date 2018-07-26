using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    interface IDataStructures<T>
    {
        void Add(ref T value);
        void Remove(ref T value);
        void Display();
        void Sort();
    }
}
