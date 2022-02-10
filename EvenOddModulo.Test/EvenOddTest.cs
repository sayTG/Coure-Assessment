using NUnit.Framework;
using EvenOddModulo;
using System;

namespace EvenOddModulo.Test
{
    [TestFixture]
    public class EvenOddTest
    {
        [Test]
        public void EvenOddModuloTest()
        {
            int[] ans = { 11, 9, 12, 16};
            int i = 0;
            foreach (var sample in Samples())
            {
                //compare the valid answer with the result from EvenOdd method
                Assert.AreEqual(ans[i], Modulo.EvenOdd(sample));
                i++;
            }
        }
        //data samples
        private int[][] Samples()
        {
            int[][] samples = new int[4][];
            samples[0] = new[] { 1, 2, 3, 4, 5 };
            samples[1] = new[] { 15, 25, 35 };
            samples[2] = new[] { 8, 8 };
            samples[3] = new[] { 8, 8, 2, 3 };
            return samples;
        }
    }
}
