using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CarRace
{
    class Race
    {

        public List<Vehicle> VehiclesList = new List<Vehicle>();


        public void SimulateRace()
        {
            for (int k = 0; k < 100; k++)
            {
                Weather.SetRaining();

                foreach (var racer in VehiclesList)
                {
                    racer.PrepareForLap(IsThereABrokenTruck());
                    racer.MoveForAnHour();
                }
            }
        }

        public void PrintRaceResults()
        {
            List<Vehicle> SortedList = VehiclesList.OrderBy(o => o.DistanceTravelled).ToList();

            for (int i = 0; i < SortedList.Count(); i++)
            {
                Console.WriteLine(SortedList[i].Name + " travelled " + SortedList[i].DistanceTravelled);
            }

        }

        public bool IsThereABrokenTruck()
        {
            bool exists = false;
            foreach (var v in VehiclesList)
            {
                if (v.Type == "truck")
                {
                    Truck truck = (Truck)v;
                    if (truck.breakdownTurnsLeft > 0)
                    {
                        exists = true;
                    }
                }
            }
            return exists;
        }
    }
}
