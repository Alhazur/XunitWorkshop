using System;

namespace ConsoleXunitWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            Calc calc = new Calc();

            double result = calc.Add(3, 7.1);

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
