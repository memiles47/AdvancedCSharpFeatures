using System;

/*
Lecture12: Lambda Expressions
*/

namespace Lecture12_Lambda_Expressions
{
    public static class LambdaExpressions
    {
        #region Math Operation Delegate

        public delegate int MathOperationDelegate(int number);

        #endregion

        #region Math Operation Method

        private static int Multiply(int value)
        {
            return value * value;
        }

        #endregion

        public static void Demo()
        {
            int value = 5;
            int result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
