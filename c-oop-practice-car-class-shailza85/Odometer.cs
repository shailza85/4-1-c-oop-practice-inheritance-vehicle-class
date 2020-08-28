using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOOP
{
    /*
     Create a “Odometer” class that has a property “Counter” with a getter and a private setter, and an Increment(count) method which will add the count to the counter. Perform reset validation in the counter’s setter, where if the new value would go over 999999, reset it to 0 and apply the excess (for example, 999980 + 40 = 000020). Write a default constructor that initializes the counter at 0.
     */

    public class Odometer
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

        private int _counter;
        public int Counter
        {
            get
            {
                return _counter;
            }
            private set
            {
                /*
                if (value > 999999)
                {
                    _counter = value % 1000000;
                }
                else
                {
                    _counter = value;
                }
                */

                _counter = value > 999999 ? value % 1000000 : value;
            }
        }

        public Odometer()
        {
            Counter = 0;
        }
        public Odometer(int counter)
        {
            Counter = counter;
        }

        public void Increment(int count)
        {
            Counter += count;
        }

        public override string ToString()
        {
            // return $"{Counter:D6}"; <-- https://docs.microsoft.com/en-us/dotnet/api/system.string.format?view=netcore-3.1
            return $"{Counter.ToString().PadLeft(6, '0')}";
        }
    }
}