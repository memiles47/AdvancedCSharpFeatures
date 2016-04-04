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

    public class Imutable_Person
    {
        public string name2 { get; } = "Michael Miles";
    }

    #endregion

    #region Auto Property with complex initializer



    #endregion

    public class AutoPropertyInitializer

    {

        #region Person Factory Property



        #endregion

        public static void Demo()
        {
            #region Use Person_With_Field

            #endregion

            #region Use Person Class

            #endregion

            #region MyRegion

            #endregion


        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
