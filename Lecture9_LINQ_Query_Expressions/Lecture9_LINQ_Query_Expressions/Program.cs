using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture9_LINQ_Query_Expressions
{
    #region

    public static class LinqQueryExpressions
    {
        public static void Demo()
        {
            string[] names = { "Billy", "Bob", "Brad", "David", "Duncan", "Everett", "Hanna", "Mark", "Michael", "Theo", "Tom", "Victor", "Wendy" };

            #region Simple foreach loop

            var results = new List<string>();
            foreach (string name in names)
            {
                if (name.StartsWith("B"))
                {
                    results.Add(name.ToUpper());
                }
            }

            #endregion

            Console.WriteLine($"{string.Join(" ", results)}");
        }
    }

    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            LinqQueryExpressions.Demo();
        }
    }
}
