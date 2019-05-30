using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // var queue = new Queue<int>(new[] { 1, 2, 3, 4, 5 });
            // var list = queue.Count;
            // var n = queue.Dequeue();
            // Console.WriteLine(list);
            // Console.WriteLine($"Dequeued item: {n}");
            // n = queue.Dequeue();
            // Console.WriteLine($"Dequeued item: {n}");
            // Console.WriteLine(queue.Count);
            // queue.Enqueue(6);
            //  Console.WriteLine(queue.Count);
            //  queue.Peek();
            //  Console.WriteLine($"There are {queue.Count} itens in the queue.");

            var stack = new Stack<int>(new[] { 1, 2, 3, 4, 5 });
            stack.Push(6);
            //var poppedItem = stack.Pop();
            var peekedItem = stack.Peek();
            //Console.WriteLine($"Popped item is {poppedItem}");
            Console.WriteLine($"Peeked item is {peekedItem}");
            Console.ReadKey();
        }
    }
}
