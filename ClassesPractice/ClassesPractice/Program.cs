namespace ClassesPractice
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car myTruck = new Car();
            myTruck.Model = "Ford F-150";
            myTruck.Year = 1997;
            myTruck.Miles = 120000;
            myTruck.TopSpeed = 100;

            myTruck.Create();

            Console.WriteLine("Truck: {0}\nYear: {1}\nMiles: {2}\nTop Speed: {3}", myTruck.Model, myTruck.Year, myTruck.Miles, myTruck.TopSpeed);
        }
    }
}