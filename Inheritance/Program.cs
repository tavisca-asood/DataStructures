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
            string genericString = "Enter 1 to add an Element.\nEnter 2 to remove an element\nEnter 3 to display.\nEnter 4 to sort.";
            int type;
            Console.WriteLine("Enter 1 to create a Linked List.\nEnter to create a Stack.\nEnter 3 to create a Queue\nEnter 4 to create Queue with fixed size.");
            int.TryParse(Console.ReadLine(), out type);
            int choice;
            int temp;
            int position;
            bool flag = true;
            switch (type)
            {
                case 1:
                    LinkedList<int> list = new LinkedList<int>();
                    while (flag)
                    {
                        Console.WriteLine(genericString);
                        Console.WriteLine("Enter 5 to add element at specific position\nEnter 6 to remove element from a specific position.\nEnter 0 to exit.");
                        int.TryParse(Console.ReadLine(), out choice);
                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("Enter the number to add");
                                int.TryParse(Console.ReadLine(), out temp);
                                list.Add(ref temp);
                                break;
                            case 2:
                                Console.WriteLine("Enter the number to remove");
                                int.TryParse(Console.ReadLine(), out temp);
                                list.Remove(ref temp);
                                break;
                            case 3:
                                list.Display();
                                break;
                            case 4:
                                list.Sort();
                                break;
                            case 5:
                                Console.WriteLine("Enter the number");
                                int.TryParse(Console.ReadLine(), out temp);
                                Console.WriteLine("Enter the index");
                                int.TryParse(Console.ReadLine(), out position);
                                list.AddAt(ref temp, position);
                                break;
                            case 6:
                                Console.WriteLine("Enter the index");
                                int.TryParse(Console.ReadLine(), out position);
                                list.RemoveAt(position);
                                break;
                            case 0:
                                flag = false;
                                break;
                        }
                    }
                    break;
                case 2:
                    Stack<int> stack = new Stack<int>();
                    while (flag)
                    {
                        Console.WriteLine(genericString);
                        Console.WriteLine("Enter 5 to push.\nEnter 6 to pop.\nEnter 6 for top value.\nEnter 0 to exit.");
                        int.TryParse(Console.ReadLine(), out choice);
                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("Enter the number to add");
                                int.TryParse(Console.ReadLine(), out temp);
                                stack.Add(ref temp);
                                break;
                            case 2:
                                Console.WriteLine("Enter the number to remove");
                                int.TryParse(Console.ReadLine(), out temp);
                                stack.Remove(ref temp);
                                break;
                            case 3:
                                stack.Display();
                                break;
                            case 4:
                                stack.Sort();
                                break;
                            case 5:
                                Console.WriteLine("Enter the number to push");
                                int.TryParse(Console.ReadLine(), out temp);
                                stack.Push(ref temp);
                                break;
                            case 6:
                                int.TryParse(Console.ReadLine(), out position);
                                stack.Pop();
                                break;
                            case 0:
                                flag = false;
                                break;
                        }
                    }
                    break;
                case 3:
                    Queue<int> queue = new Queue<int>();
                    while (flag)
                    {
                        Console.WriteLine(genericString);
                        Console.WriteLine("Enter 5 to enqueue.\nEnter 6 to Dequeue.\nEnter 7 to check if the queue is empty\nEnter 8 to check if the queue is full.\nEnter 0 to exit.");
                        int.TryParse(Console.ReadLine(), out choice);
                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("Enter the number to add");
                                int.TryParse(Console.ReadLine(), out temp);
                                queue.Add(ref temp);
                                break;
                            case 2:
                                Console.WriteLine("Enter the number to remove");
                                int.TryParse(Console.ReadLine(), out temp);
                                queue.Remove(ref temp);
                                break;
                            case 3:
                                queue.Display();
                                break;
                            case 4:
                                queue.Sort();
                                break;
                            case 5:
                                Console.WriteLine("Enter the number");
                                int.TryParse(Console.ReadLine(), out temp);
                                queue.Enqueue(ref temp);
                                break;
                            case 6:
                                queue.Dequeue();
                                break;
                            case 7:
                                if (queue.IsEmpty())
                                    Console.WriteLine("The Queue is empty");
                                else
                                    Console.WriteLine("The Queue is not empty");
                                break;
                            case 8:
                                if (queue.IsFull())
                                    Console.WriteLine("The Queue is full");
                                else
                                    Console.WriteLine("The Queue is not full");
                                break;
                            case 0:
                                flag = false;
                                break;
                        }
                    }
                    break;
                case 4:
                    Queue<int> Q=new Queue<int>();
                    while (flag)
                    {
                        Console.WriteLine(genericString);
                        Console.WriteLine("Enter 5 to enqueue.\nEnter 6 to Dequeue.\nEnter 7 to check if the queue is empty\nEnter 8 to check if the queue is full.\nEnter 9 for peek.\nEnter 0 to exit.");
                        int.TryParse(Console.ReadLine(), out choice);
                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("Enter queue size");
                                int.TryParse(Console.ReadLine(), out temp);
                                Q.Max = temp;
                                break;
                            case 2:
                                Console.WriteLine("Enter the number to remove");
                                int.TryParse(Console.ReadLine(), out temp);
                                Q.Remove(ref temp);
                                break;
                            case 3:
                                Q.Display();
                                break;
                            case 4:
                                Q.Sort();
                                break;
                            case 5:
                                Console.WriteLine("Enter the number to enqueue");
                                int.TryParse(Console.ReadLine(), out temp);
                                Q.Enqueue(ref temp);
                                break;
                            case 6:
                                Q.Dequeue();
                                break;
                            case 7:
                                if (Q.IsEmpty())
                                    Console.WriteLine("The Queue is empty");
                                else
                                    Console.WriteLine("The Queue is not empty");
                                break;
                            case 8:
                                if (Q.IsFull())
                                    Console.WriteLine("The Queue is full");
                                else
                                    Console.WriteLine("The Queue is not full");
                                break;
                            case 9:
                                Console.WriteLine(Q.Peek());
                                break;
                            case 0:
                                flag = false;
                                break;
                        }
                    }
                    break;
            }
        }
    }
}
