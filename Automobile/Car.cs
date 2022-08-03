using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobile
{
    public class Car
    {
        public decimal Mileage { get; set; }
        private decimal Fuel
        {
            get
            {
                decimal fuel = 0;
                foreach (var item in refueling_list)
                {
                    fuel += item.LitresOfFuel;
                }
                foreach (var trip in trip_list)
                {
                    fuel -= trip.DistanceToCover / this.Mileage;
                }
                return fuel;
            }
        }
        public decimal TotalDistanceTravelled
        {
            get
            {
                decimal totalTravelled = 0;
                foreach (var trip in trip_list)
                {
                    totalTravelled += trip.DistanceToCover;
                }
                return totalTravelled;
            }
        }
        public string Range
        {
            get
            {
                return ($"{Decimal.Truncate((this.Mileage * (this.Fuel - 5)))}km\n");
            }
        }
        public string OwnerName { get; set; }
        public string CarName { get; set; }

        private List<Trips> trip_list = new List<Trips>();
        private List<Refueling> refueling_list = new List<Refueling>(); 
        public Car(decimal mileage, decimal initialfuel, string ownerName, string carName)
        {
            this.Mileage = mileage;
            Refuel(initialfuel, 109);
            this.OwnerName = ownerName;
            this.CarName = carName;
        }
        public string AddTrip(decimal distanceToCover, string destination)
        {
            if (this.Fuel < 5 || distanceToCover>((this.Fuel) * this.Mileage))
            {
                throw new Exception($"{this.CarName} low on Fuel, please refuel before you start to {destination}.");
            }
            var newtrip = new Trips(distanceToCover, destination);
            trip_list.Add(newtrip);
            if (this.Fuel < 5)
            {
                return ($"{this.OwnerName}, please refuel your {this.CarName} after reaching {destination}. Happy journey!\n");
            }
            else
            {
                return ($"Hey {this.OwnerName}! Happy journey to {destination}!\n");
            }
        }
        public string Refuel(decimal litresOfFuel, decimal priceOfFuel)
        {
            var addfuel = new Refueling(litresOfFuel, priceOfFuel);
            refueling_list.Add(addfuel);
            return ($"Refuelled for {litresOfFuel} Litres and charged Rs.{litresOfFuel * priceOfFuel}. Updated range {this.Range}.\n");
        }
        public string TripHistory()
        {
            var hist = new StringBuilder();

            hist.AppendLine("Destination\t\tDistance");
            foreach (var x in trip_list)
            {
                hist.AppendLine($"{x.Destination}\t\t{x.DistanceToCover}\n");
            }
            return hist.ToString();
        }
       
    }
}