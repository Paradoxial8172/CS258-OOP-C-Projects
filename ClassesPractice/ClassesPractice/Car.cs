using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassesPractice
{
    public class Car
    {
        private string model;
        private int year;
        private int miles;
        private int topSpeed;

        public void Create()
        {
            Console.WriteLine("Congratulations, you have obtained a car built by {0} in the year {1} with {2} mile(s) with a top speed of {3}mph.", model, year, miles, topSpeed);
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public int Miles
        {
            get { return miles; }
            set { miles = value; }

        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public int TopSpeed
        {
            get { return topSpeed; }
            set { topSpeed = value; }
        }
    }
}
