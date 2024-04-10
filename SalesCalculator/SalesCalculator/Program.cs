using System.ComponentModel;

namespace SalesCalculator
{
    internal class Program
    {
        static double Calculate(double tax, double subtotal, double shippingcharge)
        {
            return (subtotal * tax * 100) + shippingcharge;
        }
        static void Main(string[] args)
        {
            double subTotal = 0.00;
            double taxRate = 0.0775;
            double shippingCharge = 0.00;
            int itemCount = 0;

            while (true)
            {

                Console.WriteLine("You currently have {0} items in your cart. Would you like to add more? Y or N.", itemCount);
                string conf = Console.ReadLine();
                if (conf == "Y" || conf == "y")
                {
                    itemCount++;
                    Console.WriteLine("What is the price of item {0}", itemCount);
                    subTotal += Convert.ToDouble(Console.ReadLine());
                    continue;
                }
                else if (conf == "N" || conf == "n")
                {
                    break;
                }
            }

            Console.WriteLine("You have ended your shopping experience with {0} items in your cart.", itemCount);

            if (itemCount > 0 && itemCount <= 3)
            {
                shippingCharge = 3.50;
            }
            else if (itemCount >= 3 && itemCount <= 6)
            {
                shippingCharge = 5.00;
            }
            else if (itemCount >= 7 && itemCount <= 10)
            {
                shippingCharge = 7.00;
            }
            else if (itemCount >= 11 && itemCount <= 15)
            {
                shippingCharge = 9.00;
            }
            else if (itemCount >= 15)
            {
                shippingCharge = 10.00;
            }

            double totalCharge = Calculate(taxRate, subTotal, shippingCharge);

            Console.Clear();
            Console.WriteLine("================================");
            Console.WriteLine("\n\tSales Receipt:");
            Console.WriteLine("Subtotal: {0,15:C2}", subTotal);
            Console.WriteLine("Sales Tax: {0,14:C2}",subTotal*taxRate);
            Console.WriteLine("Number of Items: {0,8}", itemCount);
            Console.WriteLine("Shipping Charge: {0,8:C2}", shippingCharge);
            Console.WriteLine("================================");
            Console.WriteLine("Total: {0,18:C2}", totalCharge);
        }
    }
}