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
            string[] names = { "Billy", "Michael", "Brad", "David", "Duncan", "Everett", "Hanna", "Mark", "Bob", "Theo", "Tom", "Victor", "Wendy" };

            #region Simple foreach loop

            var results1 = new List<string>();
            foreach (string name in names)
            {
                if (name.StartsWith("B"))
                {
                    results1.Add(name.ToUpper());
                }
            }

            #endregion

            #region Nested linq extension methods

            var results2 = names.Where(n => n.StartsWith("B")).Select(n => n.ToUpper());

            #endregion

            #region linq query expression

            var results3 = from n in names where n.StartsWith("B") select n.ToUpper();

            #endregion

            #region linq query with any



            #endregion

            Console.WriteLine($"{string.Join(" ", results1)}");
            Console.WriteLine($"{string.Join(" ", results2)}");
            Console.WriteLine($"{string.Join(" ", results3)}");
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
