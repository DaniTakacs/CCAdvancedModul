using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRace
{
    class Truck:Vehicle
    {
        int breakdownProbability = 5;
        public int breakdownTurnsLeft;

        Random random = new Random(Guid.NewGuid().GetHashCode());

        public Truck()
        {
            this.Type = "truck";
            this.Name = random.Next(100,999).ToString();
            this.breakdownTurnsLeft = 0;
            this.NormalSpeed = 100;
            this.ActualSpeed = NormalSpeed;
            this.DistanceTravelled = 0;
        }

        void IsBreakdown()
        {
            this.breakdownTurnsLeft = random.Next(1,100) <= breakdownProbability ? 2 : 0;
        }

        
        public override void PrepareForLap(bool IsThereABrokenTruck)
        {
            if (breakdownTurnsLeft > 0)
            {
                this.ActualSpeed = 0;
                breakdownTurnsLeft--;
            }
            else
            {
                IsBreakdown();
                if (breakdownTurnsLeft == 0)
                {
                    this.ActualSpeed = 100;
                }
                else
                {
                    this.ActualSpeed = 0;
                    breakdownTurnsLeft--;
                }
            }
        }
    }
}
