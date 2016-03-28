using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Lecture10_Yield_Return_Statement
{
    #region Regular enumerator class

    public class FibonacciSequence : IEnumerator
    {
        private int current = 1;
        private int previous = 1;

        public IEnumerator GetEnumertor()
        {
            return this;
        }

        object IEnumerator.Current
        {
            get { return current; }
        }

        public bool MoveNext()
        {
            int old = current;
            current = current + previous;
            previous = old;
            return current <= 100;
        }

        public void Reset()
        {
            current = 1;
            previous = 1;
        }
    }

    #endregion

    public static class YieldReturn
    {
        #region Enumerator method using Yield Return

        public static IEnumerable<int> GetFibonacciSequence()
        {
            int current = 1;
            int previous = 1;
            while (current <= 100)
            {
                yield return current; //The magic happens here!
                int old = current;
                current = current + previous;
                previous = old;
            }
        }

        #endregion

        public static void Demo()
        {
            #region All even numbers below 100

            var results =
                from i in Enumerable.Range(1, 98)
                where i % 2 == 0
                select i;

            foreach (int i in results)
            {
                Console.Write($"{i}");
                Console.Write(" ");
            }
            Console.WriteLine("\n");

            #endregion

            #region Fibonacci sequence from regular enumerator

            var results1 = new FibonacciSequence();

            Console.WriteLine("\n");

            #endregion

            #region Fibonacci sequence from yield return method

            var results2 = GetFibonacciSequence();

            foreach (int i in results2)
            {
                Console.Write($"{i}");
                Console.Write(" ");
            }

            #endregion
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            YieldReturn.Demo();
        }
    }
}
