namespace MethodsPractice
{
    internal class Program
    {

        public static void HelloWorld()
        {
            Console.WriteLine("Hello World!");
        }

        public static void GoodbyeWorld()
        {
            Console.WriteLine("Goodbye World!");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please select an option");
            Console.WriteLine("1) Hello World! \n2) Goodbye World!");
            int option = Convert.ToInt32(Console.ReadLine());

            if (option == 1)
            {
                HelloWorld();
            }
            else if (option == 2)
            {
                GoodbyeWorld();
            }
        }
    }
}