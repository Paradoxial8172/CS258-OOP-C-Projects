using System;
using System.Collections.Generic;

namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<dynamic> myList = new List<dynamic> ();
            myList.Add(3);
            myList.Add("Hello");
            myList.Add(3.14159265);

            Console.WriteLine(myList[0]); //element 1
            Console.WriteLine(myList[1]); //element 2
            Console.WriteLine(myList[2]); //element 3
        }
    }
}