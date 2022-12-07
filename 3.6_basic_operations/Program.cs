using System;

namespace MyNameSpase
{
    class myclass
    {
        public static void Main(string[] args)
        {
            double a = 5, b = 2;

            double result = a / b;      //Операция деления
            Console.WriteLine("{0}/{1}={2}", a, b, result);

            double result_remains = a % b;
            Console.WriteLine("{0} % {1} = {2}", a, b, result_remains);
        }
    }
}
