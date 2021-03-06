using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            var fib = new int[3] {1, 2, 3};
            var answer = 2;
            while (fib[2] < 4000000)
            {
                if (fib[2] % 2 == 0)
                {
                    answer += fib[2];
                }
                fib[0] = fib[1];
                fib[1] = fib[2];
                fib[2] = fib[0] + fib[1];
            }
            Console.WriteLine(answer);
        }
    }
}
