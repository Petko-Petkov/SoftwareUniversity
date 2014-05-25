/*Define a method Fib(n) that calculates the nth Fibonacci number. */

namespace FibonacciNumbers
{
    using System;
    
    class FibonacciMain
    {        
        static int Fibonacci(int number)
        {
            int result = 0;
            int first = 0;
            int second = 1;

            for (int i = 0; i < number; i++)
            {
                result = first + second;
                first = second;
                second = result;
                result = first;
            }

            return result;
        }
        static void Main()
        {
            Console.WriteLine("Input element n: ");
            Console.WriteLine("N-th element of the fibonacci sequence is {0}", Fibonacci(int.Parse(Console.ReadLine()))); 
        }
    }
}
