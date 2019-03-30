using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace MIC.Volo.FibSequence.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 100;
            int start = 0;
            if (args.Length == 1)
            {
                int.TryParse(args[0], out count);
            }
            else if (args.Length == 2)
            {
                int.TryParse(args[0], out start);
                int.TryParse(args[1], out count);
            }
            else if (args.Length > 2)
            {
                throw new ArgumentException("Invalid number of arguments given", nameof(args));
            }

            start = Math.Max(start - 1, 0);
            var fibs = FibonacciSequence();
            int counter = 1;
            foreach (var num in fibs.Skip(start).Take(count))
            {
                Console.WriteLine($"{start+counter++}: {num}");
            }
        }

        /// <summary>
        /// A Function that gets Fibonacci sequence
        /// </summary>
        /// <returns>IEnumerable</BigInteger></returns>
        public static IEnumerable<BigInteger> FibonacciSequence()
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
