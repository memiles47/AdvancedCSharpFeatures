using System;

namespace Lecture6_StringMethods
{
    //Testing VS 2017
    //I heard from Angie yesterday... one word 'yeah', that was it
    //I knew this would happen but I still don't like it.

    public static class StringMethods
    {
        #region GetFullName with explicit null check (GetFullName_ExplicitNull)

        public static string GetFullName_ExplicitNull (string firstName, string lastName)
        {
            if (firstName == null || firstName.Length == 0)
            {
                return lastName;
            }
            else
            {
                return firstName + " " + lastName;
            }
        }

        #endregion

        #region GetFullName with isnullorempty check (GetFullName_IsNullOrEmpty)

        public static string GetFullName_IsNullOrEmpty(string firstName, string lastName)
        {
            if (string.IsNullOrEmpty(firstName))
            {
                return lastName;
            }
            else
            {
                return firstName + " " + lastName;
            }
        }

        #endregion

        #region GetFullName with explicit empty check (GetFullName_ExplicitEmpty)

        public static string GetFullName_ExplicitEmpty(string firstName, string lastName)
        {
            if (firstName == null || firstName.Trim().Length == 0)
            {
                return lastName;
            }
            else
            {
                return firstName + " " + lastName;
            }
        }

        #endregion

        #region GetFullName with IsNullOrWhiteSpace check (GetFullName_IsNullOrWhiteSpace)

        public static string GetFullName_IsNullOrWhiteSpace(string firstName, string lastName)
        {
            if (string.IsNullOrWhiteSpace(firstName))
            {
                return lastName;
            }
            else
            {
                return firstName + " " + lastName;
            }
        }

        #endregion

    }
    class Program
    {
        static void Main(string[] args)
        {
            string result = null;

            #region Explicit null check

            result = StringMethods.GetFullName_ExplicitNull(null, "Miles");
            Console.WriteLine($"Explicit Null: {result}");

            #endregion

            #region IsNullOrEmpty check

            result = StringMethods.GetFullName_IsNullOrEmpty("", "Miles");
            Console.WriteLine($"Is Null or Empty: {result}");

            #endregion

            #region Explicit Empty check

            result = StringMethods.GetFullName_ExplicitEmpty("    ", "Miles");
            Console.WriteLine($"Explicit Empty: {result}");

            result = StringMethods.GetFullName_ExplicitEmpty("Michael", "Miles");
            Console.WriteLine($"Explicit Empty: {result}");

            #endregion

            #region IsNullOrWhiteSpace check

            result = StringMethods.GetFullName_IsNullOrWhiteSpace("    ", "Miles");
            Console.WriteLine($"Is null or white space: {result}");

            #endregion

            result = "MiKE MIlEs";

            #region Case Sensitive check

            Console.WriteLine($"Is this Mike? {result == "Mike Miles"}");

            #endregion

            #region UpperCase check

            Console.WriteLine($"Is this Mike? {result.ToUpper() == "MIKE MILES"}");

            #endregion

            #region Case Insensitive check

            //This is a case insensitive check requiring much more code however is more conservative in memory usage
            Console.WriteLine($"Is this Mike? {string.Equals(result, "Mike Miles", StringComparison.OrdinalIgnoreCase)}");

            #endregion

        }
    }
}
