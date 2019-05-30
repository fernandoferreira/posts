using System;
using System.Collections.Generic;

namespace YieldExample
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var value in Power(2, 3))
            {
                System.Console.WriteLine(value);
            }

            Console.ReadKey();
        }

        static IEnumerable<int> Power(int number, int exponent)
        {
            int result = 1;
            for (int i = 1; i <= exponent; i++)
            {
                yield return result *= number;
            }
        }
    }




    
    // static IEnumerable<int> GetCustomValues()
    // {
    //     List<int> myList = new List<int>();

    //     for (int i = 0; i < 10; i++)
    //     {
    //         if (i > 5)
    //             myList.Add(i);
    //     }
    //     return myList;
    // }


    // static IEnumerable<int> GetCustomValues()
    // {
    //     for (int i = 0; i < 10; i++)
    //         if (i > 5)
    //             yield return i;
    // }




    // static IEnumerable<int> Fibonacci(int size)
    // {
    //     int current = -1, fib = 0, next = 1;

    //     for (int i = 1; i <= size; i++)
    //     {
    //         fib = current + next;
    //         current = next;
    //         next = fib;
    //         yield return fib;
    //     }
    // }

}
