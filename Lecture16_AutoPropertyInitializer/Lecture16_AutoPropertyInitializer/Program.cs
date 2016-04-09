using System;

/*
Lecture 16: AutoProperty Initializer
*/

namespace Lecture16_AutoPropertyInitializer
{
    #region class with Public Field

    public class Person_With_Field
    {
        public string name = "Michael Miles";
    }

    #endregion

    #region class with Auto Property Initializer

    public class Person
    {
        public string name1 { get; set; } = "Michael Miles";
    }

    #endregion

    #region Immutable class with Auto Property Initializer

    public class Immutable_Person
    {
        public string name2 { get; } = "Michael Miles";
    }

    #endregion

    #region Auto Property with complex initializer

    public class Complex_Person
    {
        public string userName { get; } = "Me as current User"; //Get current user check course
    }

    #endregion

    public class AutoPropertyInitializer
    {
        #region Person Factory Property

        /*
        Lazy loading stuff again. Need much more experience. I don't
        really understand what they mean by lazy loading at all
        */

        #endregion

        public static void Demo()
        {
            #region Use Person_With_Field

            //Create instance of Person_With_Field
            Person_With_Field PersonWithField = new Person_With_Field();

            //Use name field of Person_With_Field instance PersonWithField
            Console.WriteLine($"{PersonWithField.name}");

            #endregion

            #region Use Person Class

            //Create instance of Person class
            Person MyPerson = new Person();

            //Use name1 field of MyPerson instance of Person class
            Console.WriteLine($"{MyPerson.name1}");

            #endregion

            #region Immutable Person class

            //Create instance of Immutable_Person class
            Immutable_Person MyImmutablePerson = new Immutable_Person();

            //Use name2 field of MyImmutablePerson instance of Immutable_Person class
            Console.WriteLine($"{MyImmutablePerson.name2}");

            #endregion

            #region Complex_Person Class

            //Create instance of Complex Person Class
            Complex_Person Me = new Complex_Person();

            //Use userName field of Me instance of Complex_Person Class
            Console.WriteLine($"{Me.userName}");

            #endregion
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            AutoPropertyInitializer.Demo();
        }
    }
}
