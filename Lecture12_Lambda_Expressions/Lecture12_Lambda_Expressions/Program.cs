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
            #region Variable Declaration

            int value = 5;
            int result;
            int result1;
            int result2;

            #endregion

            #region Use Math Operation Delegate

            MathOperationDelegate operation1 = new MathOperationDelegate(Multiply);
            result = operation1(value);

            #endregion

            #region Use Generic Delegate

            Func<int, int> operation2 = Multiply;
            result1 = operation2(value);

            #endregion

            #region Use Lambda Expression

            Func<int, int> operation3 = (x) => x * x;
            result2 = operation2(value);

            #endregion

            #region Print Statements

            Console.WriteLine(result);
            Console.WriteLine(result1);
            Console.WriteLine(result2);

            #endregion

            #region Cancel KeyPress delegate

            Console.CancelKeyPress += (sender, e) =>
            {
                Console.WriteLine("CTRL+C detected!\n");
                e.Cancel = true;
            };

            #endregion

            #region Lambda that creates lambdas

            Func<string, ConsoleCancelEventHandler> makeHandler =
                (message) =>
                (sender, e) =>
                {
                    Console.WriteLine(message);
                    e.Cancel = true;
                };

            Console.CancelKeyPress += makeHandler("Aborted!");
            Console.CancelKeyPress += makeHandler("Hello World!");

            #endregion

            Console.ReadLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            LambdaExpressions.Demo();
        }
    }
}
