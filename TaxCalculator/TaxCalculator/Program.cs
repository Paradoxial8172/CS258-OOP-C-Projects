namespace TaxCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tax Calculator! Calculate your total amount dues with added tax!");
            Console.WriteLine("Start by entering in your subtotal:");
            double subTotal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Your total amount including tax will be ${0}, with tax being ${1}.", (subTotal*1.07), (subTotal * 0.07));
            Console.WriteLine("Calculation:");
            Console.WriteLine("{0} + ({0} * {1}) = {2}", subTotal, 0.07, (subTotal * 1.07));

        }
    }
}