using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRace
{
    class Weather
    {

        protected static bool isRaining = false;
        protected static int rainProbability = 30;
        protected static Random random = new Random(Guid.NewGuid().GetHashCode());

        public static void SetRaining()
        {
            int randomPercent = random.Next(1,100);
            Console.WriteLine(randomPercent);

            isRaining = randomPercent <= rainProbability;
        }

        public static bool GetRaining()
        {
            return isRaining;
        }

    }
}
