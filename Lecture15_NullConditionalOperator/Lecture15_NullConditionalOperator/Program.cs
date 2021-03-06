﻿using System;
using System.Collections.Generic;

/*
Lecture 15: Null Conditional Operator
*/

namespace Lecture15_NullConditionalOperator
{
    public class NullConditionalOperator
    {
        #region Truncate Method

        //Truncating a string ignoring possible null strings which will cause an error
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
            return value?.Substring(0, Math.Min(value.Length, length)).PadRight(value.Length);
        }

        #endregion

        //More experience needed below
        #region Picknonnull Extension Method

        //These methods will have to wait until I have much more experience

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
            Console.WriteLine($"{name2 ?? "The name is null"}, Length = {name2?.Length ?? 0}");

            #endregion

            #region Length Check
            //This was combined with the Padded Truncate Call
            #endregion
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            //Create new instance of the NullConditionalOperator Class and call the Demo method
            NullConditionalOperator MyNCO = new NullConditionalOperator();
            MyNCO.Demo();

            Console.WriteLine();
        }
    }
}
