using System;

namespace Main
{
    internal class Struct
    {

        struct stStudent
        {
            public string FirstName;
            public string LastName;
        }

        static void Main(string[] args)
        {

            //A struct object can be created with or without the new operator,
            //same as primitive type variables.

            stStudent Student;
            stStudent Student2 = new stStudent();

            Student.FirstName = "Ali";
            Student.LastName = "Almeshal";

            Console.WriteLine(Student.FirstName);
            Console.WriteLine(Student.LastName);

            Student2.FirstName = "Mohamed";
            Student2.LastName = "Alsaubaii";

            Console.WriteLine(Student2.FirstName);
            Console.WriteLine(Student2.LastName);

        }
    }
}