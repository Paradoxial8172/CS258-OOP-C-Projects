using System;

namespace Matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  
             *    0 1 2
             * 0 [1,3,5]
             * 1 [2,4,6]
             * 
             */
            int[,] myMatrix = { { 1, 3, 5 }, { 2, 4, 6 } };
            Console.WriteLine(myMatrix[1,1]); // [horozontal index pos, vertical index pos]
            //Example: myMatrix[1,1] will return 4 because 4 lies on index pos 1 on the vertical AND horozontal sides.
            // Example: myMatrix[1, 2] will return 6 because 6 lies on index pos 2 for vetival side and index pos 1 on horozontal side.
            // Example: myMatrix[1, 0] will return 1 because 1 lies on index pos 1 for the horozontal side and index pos 0 for the vertical side.
        }
    }
}