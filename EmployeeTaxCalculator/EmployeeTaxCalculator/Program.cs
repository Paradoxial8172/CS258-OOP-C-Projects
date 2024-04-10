namespace EmployeeTaxCalculator
{
    internal class Program
    {

        static void Display(string lastName, double taxRate, double airTax, double socialSecurityTax, double payRate, string payType)
        {
            double takeHomePay = (taxRate + airTax + socialSecurityTax) * payRate;
            Console.WriteLine("The employee {0} has made a total of {1:C}. With a basic tax rate of {2}%, air tax of {3}%, and a social security tax of {4}%, {0}'s take-home pay will be {5:C} each hour or each pay check.", lastName, payRate, taxRate*100, airTax*100, socialSecurityTax*100, takeHomePay);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Employee Tax Calculator! To get started, enter the following information.");
            Employee Person = new Employee();
            Console.WriteLine("Enter the last name of your employee:");
            Person.LastName = Console.ReadLine();
            Console.WriteLine("Now, enter the pay type for your employee. Enter '0' for hourly, or '1' for salary:");
            Person.PayType = Convert.ToInt32(Console.ReadLine());
            string explicitPayType = "";
            if (Person.PayType == 0)
            {
                explicitPayType = "Hourly";
            }
            else if (Person.PayType == 1)
            {
                explicitPayType = "Salary";
            }
            else
            {
                Console.WriteLine("Option invalid, please chose either '0' for hourly pay, or '1' for salary. \nProgram terminated.");
            }
            Console.WriteLine("Finally, enter the pay rate of your employee:");
            Person.PayRate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Information Entered: \nEmployee: {0} \nPay Type: {1} \nPay Rate: {2:C}", Person.LastName, explicitPayType, Person.PayRate);
            if (Person.PayType == 0) //If employee is 
            {
                double taxRate = 0;
                double socialSecurityRate = 0.10;
                double airTax = 0.25;

                if (Person.PayRate > 100.0)
                {
                    taxRate = 0.10;
                }
                else if ((Person.PayRate > 50.0 && Person.PayRate < 100.0) && Person.LastName == "Watney")
                {
                    taxRate = 0.02;
                }
                else if ((Person.PayRate > 50.0 && Person.PayRate < 100.0) && Person.LastName != "Watney")
                {
                    taxRate = 0.08;
                }
                else if (Person.PayRate < 50.0)
                {
                    taxRate = 0.05;
                }
                Console.WriteLine("============================================");
                Display(Person.LastName, taxRate, airTax, socialSecurityRate, Person.PayRate, explicitPayType);
            }
            else if (Person.PayType == 1) 
            {
                double taxRate = 0;
                double socialSecurityRate = 0.10;
                double airTax = (Person.PayRate / 1000.0) * 0.25;

                if (Person.LastName == "Watney")
                {
                    taxRate = 0.0;
                }
                else if (Person.PayRate <= 10000.0)
                {
                    taxRate = 0.22;
                }
                else if (Person.PayRate > 5000.0 && Person.PayRate < 10000.0)
                {
                    taxRate = 0.18;
                }
                else if (Person.PayRate < 5000.0)
                {
                    taxRate = 0.15;
                }

                Console.WriteLine("============================================");
                Display(Person.LastName, taxRate, airTax, socialSecurityRate, Person.PayRate, explicitPayType);
            }
        }
    }
}