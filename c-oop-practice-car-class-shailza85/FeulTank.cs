using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOOP
{
    /*
      Create a “FuelTank” class that has properties “Capacity” and “Level” (both represent a value in litres). Level should throw an exception below 0, and be clamped at the capacity. Both should have private setters. Add A BurnFuel(litres) method and a Fill(litres) method. Write a default constructor that initializes capacity at 50L and level at 50L.
     */
    public class FuelTank
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

        private double _capacity;
        public double Capacity
        {
            get
            {
                return _capacity;
            }
            private set
            {
                // See Odometer for an example similar to this.
                _capacity = value < 0 ? 0 : value;
            }
        }
        private double _level;
        public double Level
        {
            get
            {
                return _level;
            }
            private set
            {
                /*
                if (value < 0)
                {
                    throw new Exception("Value less than 0!");
                }
                else if (value > Capacity)
                {
                    _level = Capacity;
                }
                else
                {
                    _level = value;
                }
                */

                _level = value < 0 ? throw new Exception("Value less than 0!") : value > Capacity ? Capacity : value;
            }
        }

        public FuelTank()
        {
            Capacity = 50;
            Level = 50;
        }

        public void BurnFuel(double litres)
        {
            // Setter takes care of validation.
            Level -= litres;
        }

        public void Fill(double litres)
        {
            // Setter takes care of validation.
            Level += litres;
        }
    }
}