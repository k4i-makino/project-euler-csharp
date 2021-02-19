using System;
using System.Linq;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            var answer = 0;

            answer = Enumerable.Range(1, 999)
                    .Where(i => i % 5 == 0 || i % 3 == 0)
                    .Sum();

            Console.WriteLine(answer);
        }
    }
}
