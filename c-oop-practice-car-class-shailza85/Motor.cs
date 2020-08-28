using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOOP
{
    public class Motor
    {
        private Car _car;
        public Car Car
        {
            get
            {
                return _car;
            }
            set
            {
                _car = value;
            }
        }

        public double FuelEfficiency { get; set; }

        public Motor()
        {
            FuelEfficiency = 10;
        }
        public Motor(double fuelEfficiency)
        {
            FuelEfficiency = fuelEfficiency;
        }
    }
}