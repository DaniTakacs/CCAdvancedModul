using System;

namespace CarRace
{
    class Program
    {
        static void Main(string[] args)
        {
            Race race = new Race();
            CreateVehicles(race);

            race.SimulateRace();
            race.PrintRaceResults();

            Console.ReadKey();
        }


        private static void CreateVehicles(Race race)
        {
            for (int i = 0; i < 10; i++)
            {
                Car car = new Car();
                race.VehiclesList.Add(car);
                Motorcycle motorcycle = new Motorcycle();
                race.VehiclesList.Add(motorcycle);
                Truck truck = new Truck();
                race.VehiclesList.Add(truck);
            }
        }

    }
}
