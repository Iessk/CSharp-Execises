using System;

namespace Main
{
    internal class Enums
    {
        enum enWeekDays // 
        {
            Monday,     // 0
            Tuesday,    
            Wednesday,  
            Thursday,   
            Friday,     
            Saturday,
            Sunday      // 6
        }

        enum enDirection : byte
        {
            North,
            South,
            East,
            West
        }
        static void Main(string[] args)
        {
            enDirection direction = enDirection.North;

            if (direction == enDirection.North)
            {
                Console.WriteLine("head north");
            }

        }
    }
}
