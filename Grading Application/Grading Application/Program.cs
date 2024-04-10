using System.Linq;

namespace Grading_Application
{
    internal class Program
    {
        static double CalculateAverageGrade(double[] array)
        {
            double averageGrade = 0;
            for (int i = 0; i < array.Length; i++)
            {
                 averageGrade += array[i];
            }

            return averageGrade / 5;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grading Application. This application will take grades for 5 students and list them and their grade respectively along with the class average. Start by entering in your grades:");
            Console.WriteLine("Enter Grade for Abigail");
            double grade_one = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Grade for Charles");
            double grade_two = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Grade for David");
            double grade_three = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Grade for Josh");
            double grade_four = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Grade for Kayla");
            double grade_five = Convert.ToDouble(Console.ReadLine());

            double[] grades = new double[] {grade_one, grade_two, grade_three, grade_four, grade_five};

            Console.WriteLine("\n\n");
            Console.WriteLine("Average Grades: {0}%\n ", CalculateAverageGrade(grades));
            Console.WriteLine("Students:    Grades:");
            Console.WriteLine("Abigail: \t{0}%", grades[0]);
            Console.WriteLine("Charles: \t{0}%", grades[1]);
            Console.WriteLine("David: \t\t{0,2}%", grades[2]);
            Console.WriteLine("Josh: \t\t{0,2}%", grades[3]);
            Console.WriteLine("Kayla: \t\t{0,2}%", grades[4]);

        }
    }
}