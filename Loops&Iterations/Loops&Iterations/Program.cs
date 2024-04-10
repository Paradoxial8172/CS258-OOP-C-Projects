namespace Loops_Iterations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("While loop iteration");
            Console.WriteLine("-------------------------------");
            int num = 0;
            while (num < 10)
            {
                Console.WriteLine(num + 1);
                num++;
            }
            Console.WriteLine("For loop iteration");
            Console.WriteLine("-------------------------------");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i + 1);

            } 
        }
    }
}