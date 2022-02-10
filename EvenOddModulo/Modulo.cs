using System;

namespace EvenOddModulo
{
    public class Modulo
    {
        //return the sum based on the condition
        public static int EvenOdd(int[] arr)
        {
            int sum = 0;
            foreach(int num in arr)
            {
                if (num < 0) // check if the number from array is negative
                    throw new Exception("Negative number is not accepted.");
                else
                {
                    if (num == 8) // check if the number from array is 8
                        sum += 5;

                    var result = num % 2;
                    if (result == 0) //check if it is even number
                        sum += 1;
                    else // check if it is odd
                        sum += 3;
                }
                
            }
            return sum;
        }
    }
}
