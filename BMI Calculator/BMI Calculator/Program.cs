using static System.Math;

namespace BMI_Calculator
{
    internal class Program
    {
        static string Name()
        {
            Console.WriteLine("Enter your Name.");
            string name = Console.ReadLine();
            return name;
        }

        static double Weight()
        {
            Console.WriteLine("Enter your weight in pounds.");
            double weight = Convert.ToDouble(Console.ReadLine());
            return weight;
        }
        static double Height()
        {
            Console.WriteLine("Enter your height in inches.");
            double height = Convert.ToDouble(Console.ReadLine());
            return height;
        }

        static double Calculate(double weight, double height)
        {
            return Math.Round(weight / (Math.Pow(height, 2)), 2) * 703;
        }

        static void Display(double weight, double height, string name, double BMI) {
            Console.WriteLine("{0}, your calculated BMI is {1}, with a weight of {2}lbs and a height of {3} inches.", name, BMI, weight, height);
        }
        static void Main(string[] args)
        {
            string name = Name();
            double height = Height();
            double weight = Weight();
            double calculation = Calculate(weight, height);
            Display(weight, height, name, calculation);
        }
    }
}