using System;

namespace Main
{
    internal class Dynamic
    {

        static void Main(string[] args)
        {

            dynamic MyDynamicVar = 100;
            Console.WriteLine("Value : {0} , Type : {1} ", MyDynamicVar, MyDynamicVar.GetType());

            MyDynamicVar = "Hello, World!";
            Console.WriteLine("Value: {0} , Type : {1} ", MyDynamicVar, MyDynamicVar.GetType());

            MyDynamicVar = false;
            Console.WriteLine("Value : {0} , Type : {1} ", MyDynamicVar, MyDynamicVar.GetType());

            MyDynamicVar = DateTime.Now;
            Console.WriteLine("Value : {0} , Type : {1} ", MyDynamicVar, MyDynamicVar.GetType());
            
            // acts like var but you can change its type
            // the dynamic handle the type during runtime
        }
    }
}
