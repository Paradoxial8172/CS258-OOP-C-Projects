using System.Collections;
using System.ComponentModel;

namespace CasesSwitches_More
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:                    
                    Console.WriteLine("Number is 1.");
                    break;
                case 2:
                    Console.WriteLine("Number is 2.");
                    break;

            }
        }
    }
}