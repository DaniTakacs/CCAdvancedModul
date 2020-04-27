using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRace
{
    abstract class Vehicle
    {
        public String Type;
        public String Name;
        protected int NormalSpeed;
        protected int ActualSpeed;
        public int DistanceTravelled;


        public abstract void PrepareForLap(bool IsThereABrokenTruck);
       

        public void MoveForAnHour()
        {
            this.DistanceTravelled += ActualSpeed;
        }
    }
}
