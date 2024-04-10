using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocketShuttle
{
    internal class Rocket
    {
        private int fuel;
        private int astronauts;
        private int altitude;

        public int Fuel
        {
            get { return fuel; }
            set { fuel = value; }
        }

        public int Astronauts
        {
            get { return astronauts; }
            set { astronauts = value; }
        }
    }
}
