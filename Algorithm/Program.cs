using EvenOddModulo;
using System;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            //unit test for the project is created
            int[] arr = { 1, 2, 3, 4, -5 };
            int result = Modulo.EvenOdd(arr);
            Console.WriteLine(result);
        }
    }
}
