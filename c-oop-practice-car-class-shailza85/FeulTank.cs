using System;
using System.Collections.Generic;
using System.Text;

namespace c_oop_practice_car_class_shailza85
{
    public class FeulTank
    {

        /*
         * Create a “FuelTank” class that has properties “Capacity” and “Level” (both represent a value in litres). 
         * Level should throw an exception below 0, and be clamped at the capacity. Both should have private setters. Add A BurnFuel(litres) method and a Fill(litres) method. 
         * Write a default constructor that initializes capacity at 50L and level at 50L.
         */

        private double _capacity;
        public double Capacity
        {
            get
            {
                return _capacity;
            }

            private set
            {
                if (value >= 50)
                {
                    _capacity = value;
                }
                else
                {
                    if (value < 0)
                    {
                        throw new Exception("Low Capacity!");
                    }
                    _capacity = value;
                }
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
                if (value >= 50)
                {
                    _level = value;
                }
                else
                {
                    if (value < 0)
                    {
                        throw new Exception("Low Feul Level!");
                    }
                    _level = value;
                }
            }
        }

        public FeulTank()
        {
            Capacity = 50;
            Level = 50;
        }

        public void BurnFeul(double litres)
        {
           
            Level -= litres;
        }

        public void Fill(double litres)
        {
         
            Level += litres;
        }


    }
}
