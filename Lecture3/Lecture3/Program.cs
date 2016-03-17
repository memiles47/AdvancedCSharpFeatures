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

            
            int someNumber = value ?? default(int);
            
        }
    }
}
