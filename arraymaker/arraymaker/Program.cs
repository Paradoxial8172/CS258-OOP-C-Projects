namespace arraymaker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many elements do you want in your array?");
            int elementCount = Convert.ToInt32(Console.ReadLine());
            int[] myArray = new int[elementCount];
            for (int i = 0; i < elementCount; i++)
            {
                Console.WriteLine("Enter number for element #{0}", i + 1);
                int newElement = Convert.ToInt32(Console.ReadLine());
                myArray[i] = newElement;
            }
            Console.WriteLine("Values in array:");
            int n = 0;
            foreach (int element in myArray)
            {
                Console.WriteLine("Element #{0}: {1}", n + 1, myArray[n]);
                n++;
            }
            Console.WriteLine("Reversed values in array");
            myArray.Reverse();
            int j = 0;
            foreach (int element in myArray)
            {
                Console.WriteLine("Element #{0}: {1}", j + 1, myArray[(elementCount - 1) - j]);
                j++;
            }
        }
    }
}