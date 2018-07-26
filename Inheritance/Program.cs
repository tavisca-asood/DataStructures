using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            int n = 0;
            list.Add(ref n);
            n = 30;
            list.Add(ref n);
            n = 40;
            list.Add(ref n);
            n = 80;
            list.Add(ref n);
            list.Display();
            n = 80;
            list.Remove(ref n);
            list.Display();
            Console.ReadKey();
        }
    }
}
