using System;

namespace Main
{
    internal class Program
    {

        static void Main(string[] args)
        {
            // a specific point
            DateTime dt = new DateTime(2023, 2, 21);

            // duration 
            // Hours, Minutes, Seconds 
            TimeSpan ts = new TimeSpan(49, 25, 34);

            Console.WriteLine(ts);
            Console.WriteLine(ts.Days);
            Console.WriteLine(ts.Hours);
            Console.WriteLine(ts.Minutes);
            Console.WriteLine(ts.Seconds);

            //this will add time span to the date.
            DateTime newDate = dt.Add(ts);

            Console.WriteLine(newDate);
        }
    }
}
