using System;

/*
Lesson Three: Advanced C# Features
Null Coalescing: It is much like the ternary expression
I use both in this little program
*/

namespace Lecture3
{
    class Program
    {
        static void Main(string[] args)
        {
            string value="";
            while (value != null)
            {
                Console.Write($"Enter some character or characters>");
                value = Console.ReadLine();
                
                //Using Ternary if value is "", convert to null
                value = value == "" ? null : value;

                Console.WriteLine($"Value = {value}");
            }
            //Null Coalescing within the print statement
            Console.WriteLine($"Value = {value ?? "Null"}");
        }
    }
}