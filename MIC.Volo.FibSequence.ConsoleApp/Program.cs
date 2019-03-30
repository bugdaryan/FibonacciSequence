using System;
using System.Collections.Generic;
using System.Numerics;

namespace MIC.Volo.FibSequence.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        private static IEnumerable<BigInteger> FibonacciSequence()
        {
            var a = new BigInteger(1);
            var b = new BigInteger(0);
            var c = new BigInteger(0);
            while (true)
            {
                yield return c;
                c = a + b;
                a = b;
                b = c;
            }
        }
    }
}
