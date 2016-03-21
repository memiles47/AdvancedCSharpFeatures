using System;

/*
Lesson Five: Advanced C# Features
Auto Properties

*/

namespace Lesson5
{
    #region Main Class for Program Entry

    class Program
    {
        static void Main()
        {
            //Create a new instance of the Person_Explicit Class
            Person_Explicit Person = new Person_Explicit();

            //Set a value for the name string in the created class
            Person.name = "Mike";

            //Access the name variable
            Console.WriteLine($"Person = {Person.name}");
        }
    }

    #endregion

    #region Person Class With Explicit Properties

    public class Person_Explicit
    {
        private string _name = null;

        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
    }

    #endregion

    #region Class with Auto Properties

    public class Person_Auto
    {
        public string name { get; set; }
    }

    #endregion
}
