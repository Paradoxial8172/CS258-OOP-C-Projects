using System;
using System.Collections.Generic;

namespace ArraysPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] myListOne = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            string[] myListTwo = new string[] { "Hello", "Hi", "G'day" };
            double[] myListThree = new double[] { 1.0, 1.1, 1.2, 1.3, 1.4, 1.5, 1.6, 1.7, 1.8, 1.9, 2.0 };
            char[] myListFour = new char[] { 'A', 'B', 'C', };

            int[] myListFive = new int[5]; //This ensures that there can only be 5 index positions in this list! (indes pos: 0,1,2,3,4)

            /*
             * List's indexes start from 0, so for myListOne, the value at index position 0 will be 1, and the value 
             * at index positon 1, will be 2. Lists also must all have their elements be the same data type. So for 
             * myListOne, you cannot have any strings or doubles as it is set to only contain integer elements
             * 
             * To create a list, you must type in the following;
             * (data type)[] (variable name) = new (data type)[] {(elements go here)};
             */

            Console.WriteLine(myListOne);  
        }
    }
}