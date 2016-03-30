using System;
using System.Collections.Generic;

namespace Lecture15_NullConditionalOperator
{
    public class NullConditionalOperator
    {
        #region Truncate Method

        private string Truncate(string value, int length)
        {
            return value.Substring(0, Math.Min(value.Length, length));
        }

        #endregion

        #region Protected Truncate Method

        private string Truncate_Protected (string value, int length)
        {
            return value?.Substring(0, Math.Min(value.Length, length));
        }

        #endregion

        #region Padded Truncate Method

        private string Truncate_Padded(string value, int length)
        {
            return value?.Substring(0, Math.Min(value.Length, length)).PadRight(Math.Max(value.Length - length, 0));
        }

        #endregion

        #region Picknonnull Extension Method

        #endregion

        public void Demo()
        {
            #region Valid Truncate Call

            string name = Truncate("Michael Miles", 9);
            Console.WriteLine($"{name ?? "null"}");

            #endregion

            #region Invalid Truncate Call

            //string name1 = Truncate(null, 9);
            //Console.WriteLine($"{name1 ?? "null"}");

            #endregion

            #region Protected Truncate Call

            string name1 = Truncate_Protected(null, 9);
            Console.WriteLine($"{name1 ?? "The name is null"}");

            #endregion

            #region Padded Truncate Call

            string name2 = Truncate_Padded("Michael Miles", 9);
            Console.WriteLine($"{name2 ?? "The name is null"}, Length = {name2.Length}");

            #endregion

            #region Length Check

            #endregion
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            NullConditionalOperator MyNCO = new NullConditionalOperator();
            MyNCO.Demo();

            Console.WriteLine();
        }
    }
}
