using System;

namespace app
{
    class Program
    {
        const double UPPER = 1000;

        static void Main(string[] args)
        {
            var answer = GetMultipleSum(3) + GetMultipleSum(5) - GetMultipleSum(15);

            Console.WriteLine(answer);
        }

        private static double GetMultipleSum(int n)
        {
            var sumUpper = Math.Floor((UPPER - 1) / n);
            return n * (sumUpper * (sumUpper + 1) / 2);
        }
    }
}
