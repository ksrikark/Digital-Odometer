using System;

namespace Automobile
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car(15, 20, "Steve", "Nexon");
            Console.WriteLine($"Hello {car.OwnerName}! Your {car.CarName} is ready to go.\n");
            Console.WriteLine(car.AddTrip(130, "Mumbai"));
            
            Console.WriteLine(car.Refuel(28, 110));
            Console.WriteLine(car.AddTrip(500, "Hyderabad"));
            Console.WriteLine(car.Range);
            Console.WriteLine(car.Refuel(20, 105));
            
            Console.WriteLine(car.AddTrip(335, "Vijayawada"));
          
            Console.WriteLine(car.TripHistory());
          
            Console.WriteLine(car.TotalDistanceTravelled);


        }
    }
}
