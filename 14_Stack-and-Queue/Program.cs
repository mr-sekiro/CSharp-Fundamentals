using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Channels;
using System.Xml.Linq;

namespace _14_Stack_and_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Stack
            ////Stack is a collection that stores elements in a Last In, First Out(LIFO) manner.
            ////That means the last item pushed onto the stack is the first one to be popped off.

            ////Stack<T> is type - safe, while the non - generic Stack stores items as object.
            ////Internally, Stack uses an array, and resizes automatically.

            #region Example 1
            //Stack<string> books = new Stack<string>();

            //books.Push("C#");
            //books.Push("Java");
            //books.Push("Python");

            //Console.WriteLine("Top: " + books.Peek());  //Python

            //Console.WriteLine("Popped: " + books.Pop());
            //Console.WriteLine("Top after pop: " + books.Peek());

            //Console.WriteLine("Total items: " + books.Count);

            //foreach (var book in books)
            //    Console.WriteLine(book);

            //Console.WriteLine($"Is Books include Java: {books.Contains("Java")}");

            //books.Clear(); 
            #endregion

            #region Example 2
            //AppendTextCommand command = new AppendTextCommand();
            //string input = "";

            //Console.WriteLine("Enter Text To Append ('Exit' to quit, 'Undo' to undo, 'Redo' to redo):");

            //while (true)
            //{
            //    Console.Write("> ");
            //    input = Console.ReadLine();

            //    if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
            //        break;
            //    else if (input.Equals("undo", StringComparison.OrdinalIgnoreCase))
            //    {
            //        if (command.CanUndo)
            //            command.Undo();
            //        else
            //            Console.WriteLine("You cannot undo any further changes.");
            //    }
            //    else if (input.Equals("redo", StringComparison.OrdinalIgnoreCase))
            //    {
            //        if (command.CanRedo)
            //            command.Redo();
            //        else
            //            Console.WriteLine("You cannot redo any further changes.");
            //    }
            //    else
            //    {
            //        command.Execute(input);
            //    }

            //    Console.WriteLine("Current Text: " + command.CurrentText);
            //}
            #endregion

            #endregion

            #region Queue
            //Queue is a collection that stores elements in a First In, First Out(FIFO) manner.
            //That means the first item enqueued is the first one to be dequeued.

            //Queue <T> (generic version)
            //Queue (non - generic)

            #region Example 1
            //Queue<string> queue = new Queue<string>();

            //queue.Enqueue("Customer 1");
            //queue.Enqueue("Customer 2");
            //queue.Enqueue("Customer 3");

            //Console.WriteLine("First: " + queue.Peek());

            //Console.WriteLine("Dequeued: " + queue.Dequeue());
            //Console.WriteLine("Next: " + queue.Peek());

            //Console.WriteLine("Count: " + queue.Count);

            //foreach (var customer in queue)
            //    Console.WriteLine(customer);

            //Console.WriteLine($"is the Customer 2 in the queue: {queue.Contains("Customer 2")}");

            //queue.Clear();
            #endregion

            #region Example 2
            Queue<string> files = new Queue<string>();
            string input = "";
            Console.WriteLine("please select a file to print ('Exit': to quit, 'print': to print )");
            while (true)
            {
                Console.Write(">");
                input = Console.ReadLine();

                if (input.Equals("Exit", StringComparison.OrdinalIgnoreCase))
                    break;
                else if (input.Equals("Print", StringComparison.OrdinalIgnoreCase))
                {
                    while (files.Count > 0)
                    {
                        Console.WriteLine($"Printing Document '{files.Dequeue()}'...");
                        Console.WriteLine($"Queue Count: {files.Count}");
                    }
                }
                else
                {
                    files.Enqueue(input);
                }
            }
            #endregion 

            #endregion

        }
    }
}
