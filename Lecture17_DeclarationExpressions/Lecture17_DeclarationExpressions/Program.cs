using System;
using System.Text;

/*
Lecture 17: Declaration Expressions
*/

namespace Lecture17_DeclarationExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;

            #region While loop with two declarations, one outside the loop

            //input = Console.Read();
            //while (input != 10)
            //{
            //    Console.Write((char)input);
            //    input = Console.Read();
            //}

            #endregion

            #region While loop with declaration expression

            while ((input = Console.ReadLine().ToLower()) != "exit")
            {
                Console.WriteLine($"{input}");
            }

            Console.WriteLine($"{input}");

            #endregion
        }
    }
}
