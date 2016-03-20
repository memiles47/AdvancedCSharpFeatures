using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Lesson Three of... I'll fill this in later...
*/

namespace Lecture3
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;

            Console.Write($"Enter some character or characters>");
            value = Console.ReadLine();

            if (value == "")
            {
                value = null;
            }

            value = value ?? "Null";

            Console.WriteLine($"Value = {value}");
        }
    }
}