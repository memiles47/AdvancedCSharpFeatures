using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture3
{
    class Program
    {
        static void Main(string[] args)
        {
            int? value = null;
            int someEntry;
            string s = "";

            Console.Write($"Enter anything> \"Exit\" to quit");
            while (s != "exit")
            {
                s = Console.ReadLine().ToLower();
                if (s != "exit")
                {
                    someEntry = int.TryParse(s, out value) ? value : default(int);
                }

            }
            someNumber = value ?? default(int);
            
        }
    }
}
