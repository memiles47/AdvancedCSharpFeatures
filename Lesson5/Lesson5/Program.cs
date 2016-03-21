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
            Person_Auto Person_A = new Person_Auto();
            Person_Field Person_F = new Person_Field();
            Person_Immutable_Auto Person_IA = new Person_Immutable_Auto("Mike");

            //Set a value for the name string in the created class
            Person.name = "Mike";
            Person_A.name = "Mike";
            Person_F.name = "Mike";
            //Person_IA.Name = "Michael"; //Shows an error as this field has become read only

            //Access the name variable
            Console.WriteLine($"Person = {Person.name}");
            Console.WriteLine($"Person_A = {Person_A.name}");
            Console.WriteLine($"Person_F = {Person_F.name}");
            Console.WriteLine($"Person_IA = {Person_IA.Name}");
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

    #region Person Class with Public Field

    public class Person_Field
    {
        public string name;
    }

    #endregion

    #region Immutable Person Class with Explicit Properties

    public class Person_Immutable_Explicit
    {
        private readonly string _name = null;

        public Person_Immutable_Explicit (string name)
        {
            _name = name;
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }
    }

    #endregion

    #region Immutable Person Class with Explicit Properties

    public class Person_Immutable_Private
    {
        public Person_Immutable_Private(string name)
        {
            this.Name = name;
        }

        public string Name { get; private set; }
    }

    #endregion

    #region Immutable Person Class with Auto Properties

    public class Person_Immutable_Auto
    {
        public Person_Immutable_Auto(string name)
        {
            this.Name = name;
        }

        public string Name { get; }
    }

    #endregion
}
