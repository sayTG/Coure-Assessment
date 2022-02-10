using System;

namespace EvenOddModulo
{
    public class Modulo
    {
        public static int EvenOdd(int[] arr)
        {
            int sum = 0;
            foreach(int num in arr)
            {
                if (num < 0)
                    throw new Exception("Negative number is not accepted.");
                else
                {
                    if (num == 8)
                        sum += 5;

                    var result = num % 2;
                    if (result == 0)
                        sum += 1;
                    else
                        sum += 3;
                }
                
            }
            return sum;
        }
    }
}
