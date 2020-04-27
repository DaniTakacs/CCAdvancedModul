using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRace
{
    class Motorcycle : Vehicle
    {
        static int motorcycleNumber = 0;
        private Random random = new Random(Guid.NewGuid().GetHashCode());

        public Motorcycle()
        {
            this.Type = "motorcycle";
            this.Name = "Motorcycle " + (motorcycleNumber + 1);
            motorcycleNumber++;
            this.NormalSpeed = 100;
            this.ActualSpeed = NormalSpeed;
            this.DistanceTravelled = 0;
        }

        public override void PrepareForLap(bool IsThereABrokenTruck)
        {
            if (Weather.GetRaining())
            {
                this.ActualSpeed = NormalSpeed - random.Next(5,50);
            }
        }
    }
}
