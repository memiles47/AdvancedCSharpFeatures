using System;
using System.Collections.Generic;
using System.Linq;

/*
Lecture 6: Linq queries
*/

namespace Lecture9_LINQ_Query_Expressions
{
    #region

    public static class LinqQueryExpressions
    {
        public static void Demo()
        {
            string[] names = { "Billy", "Michael", "Brad", "David", "Duncan", "Everett", "Hannah", "Mark", "Bob", "Theo", "Tom", "Victor", "Wendy" };

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

            var results4 = (
                from n in names
                where n.StartsWith("B")
                select n)
                .Any() ? "At least one name starts with \"B\"" : "No names start with\"B\"";

            #endregion

            Console.WriteLine($"{string.Join(" ", results1)}");
            Console.WriteLine($"{string.Join(" ", results2)}");
            Console.WriteLine($"{string.Join(" ", results3)}");
            Console.WriteLine($"{string.Join(" ", results4)}\n\n");

            #region Linq query with grouping

            var results5 = from n in names
                           group n by n[0] into groups
                           select groups;

            #endregion

            foreach (var grp in results5)
            {
                Console.Write($"{grp.Key}:");
                Console.WriteLine($"{string.Join(" ", grp)}");
            }
            Console.WriteLine("\n\n");

            #region Linq query with grouping and ordering

            var results6 = from n in names
                           orderby n descending
                           group n by n[0] into groups
                           orderby groups.Key descending
                           select groups;

            #endregion

            foreach (var grp in results6)
            {
                Console.Write($"{grp.Key}:");
                Console.WriteLine($"{string.Join(" ", grp)}");
            }

            #region Linq query with join

            var results7 = from n in names
                           join n2 in names on char.ToLower(n[0]) equals char.ToLower(n2[n2.Length - 1])
                           select n + ":" + n2;

            #endregion

            #region Linq query to detect vowels

            var vowels = new char[] { 'a', 'e','i', 'o', 'u' };
            var results8 =
                from n in names
                from v in vowels
                where n.IndexOf(v) >= 0
                select string.Format($"These's an {v} in {n}");

            #endregion

            #region Linq query to detect palindromes

            var results9 = from n in names
                           let forward = n.ToLower()
                           let reverse = new string(forward.ToCharArray().Reverse().ToArray())
                           where forward == reverse
                           select n;

            #endregion

            Console.WriteLine($"{string.Join("\n", results7)}\n");
            Console.WriteLine($"{string.Join("\n", results8)}\n");
            Console.WriteLine($"{string.Join("\n", results9)}");
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
